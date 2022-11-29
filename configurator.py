import os, json, re
import miner, reader



class areaCode:
    """서울시 자치구 고유코드를 읽어들이는 클래스입니다."""

    def __init__(self):
        self.__popMiner = miner.population()
        self.dir = './db'
        self.fileName = 'area_code.json'

    def __getSeoul(self) -> dict:
        """population csv 파일로부터 자치구별 고유 코드를 읽어들이는 함수입니다."""
        areaData = self.__popMiner.seoul()

        if areaData == None:
            return None

        areaData.pop('소계')

        if not os.path.isdir(self.dir):
            os.mkdir(self.dir)

        for index, key in enumerate(list(areaData.keys())):
            areaData[index + 1] = key
            areaData.pop(key)

        return areaData


    def writeSeoul(self) -> None:
        """서울시 자치구별 고유코드를 읽어 db/area_code.json 파일로 저장하는 함수입니다."""
        areaData = self.__getSeoul()

        with open(self.dir + '/' + self.fileName, 'w', encoding='utf-8') as json_file:
            json.dump(areaData, json_file, indent=4, ensure_ascii=False)
    
    def readSeoul(self) -> dict:
        """서울시 자치구별 고유코드를 읽어 {고유코드:자치구명} 형태의 dict로 반환하는 함수입니다."""
        if not os.path.isfile(self.dir + '/' + self.fileName):
            return self.__getSeoul()

        areaData = dict()
        with open(self.dir + '/' + self.fileName, 'r+', encoding='utf-8') as json_file:
            areaData = json.load(json_file)

        for key, value in areaData.items():
            if not (str(key).isdigit() or str(value).endswith('구')):
                return self.__getSeoul()

        return areaData
        


class subwayStation:
    """자치구별로 존재하는 지하철 역들을 읽어들이는 클래스입니다."""

    def __init__(self):
        self.__dfReader = reader.dataframe()

    def readSeoul(self) -> dict:
        """모든 서울시 지하철 역을 자치구별로 분류해 {자치구명:[역명1, 역명2, 역명3, ...]} 형태의 dict로 반환하는 함수입니다."""
        dataframe = self.__dfReader.fromCsv("subwayarea")
        if dataframe is None:
            return None

        areas = dataframe['자치구'].values
        raw_stations = dataframe['해당역(호선)'].values
        area_stations = {}

        for index, stations in enumerate(raw_stations):
            # 정규 표현식을 이용해 "용마산(7), 망우(중앙)"와 같은 문자열을 "용마산, 망우"로 치환하여 불필요한 호선명 제거
            pattern = r"\([0-9A-Za-z가-힣]+\)"
            stations = re.sub(pattern, "", stations)

            # 자치구별로 모든 역 저장
            area_stations[areas[index]] = stations.split(", ")

        return area_stations


