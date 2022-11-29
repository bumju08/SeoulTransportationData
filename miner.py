import os, json, datetime, pandas, pandas.core.frame
import reader, configurator


class population:
    """인구수 데이터 처리 클래스입니다."""

    def __init__(self):
        self.__dfReader = reader.dataframe()

    def seoul(self) -> dict:
        """서울시 자치구별 인구수를 추출하여 반환하는 함수입니다."""

        data = dict()
        dataframe = self.__dfReader.fromCsv("population")

        if dataframe is None:
            return None

        # 남자와 여자에 대한 별도 데이터와 자치구별의 데이터에 대한 각각의 열의 이름 추출
        col_sex = ""
        col_area = ""
        col_year = datetime.datetime.now().year
        for column in dataframe.columns:
            values = dataframe[column].values
            sexFound = False
            separators = ['남자', '여자', '남성', '여성']

            # 현재 열의 값들에 성별이 적혀 있으면 소계가 적힌 '구분별(2)' 열로 판단
            for separator in separators:
                if separator in values:
                    sexFound = True
                    break

            # 현재 열의 값들에 자치구의 이름이 있는지 확인하고 카운팅
            validAreaCount = 0
            for value in values:
                value = str(value)

                if value != "총인구" and value.endswith('구'):
                    validAreaCount += 1

            # 카운트가 20 넘어가면 현재 열을 '자치구별(2)' 열로 판단
            if validAreaCount > 20:
                col_area = column

            elif sexFound:
                col_sex = column

            areaFound = len(col_area) > 0
            if areaFound and sexFound:
                break

        # 각 자치구별 인구수 추출
        sexes = dataframe[col_sex].values
        areas = dataframe[col_area].values
        for index, value in enumerate(dataframe[str(col_year)]):
            _area = str(areas[index])
            _sex = str(sexes[index])

            if not _sex.endswith('계'):
                continue
            
            data[_area] = value


        return data




class transport:
    """교통 데이터 처리 클래스입니다."""

    def __init__(self):
        self.__dfReader = reader.dataframe()
        self.__codeGenerator = configurator.areaCode()

    def bus(self) -> dict:
        """자치구별 버스 승하차 데이터를 dict 형태로 반환하는 함수입니다."""

        dataframe = self.__dfReader.fromCsv("bus")
        if dataframe is None:
            return None

        # 승차, 하차, 버스정류장ID에 대한 열 이름과 승하차 승객 데이터 읽기
        col_area = ""
        passenger_data = {}
        for column in dataframe.columns:
            column = str(column)

            if "ars" in column.lower():
                col_area = column

            elif "승객" in column:
                passenger_data[column] = dataframe[column].values

        # 자치구 이름 읽고 값 초기화
        bus_usage = population().seoul()
        for key in bus_usage.keys():
            bus_usage[key] = {"in":0, "out":0}

        # 자치구별 코드 추출
        areaCodes = self.__codeGenerator.readSeoul()

        # 데이터 추출
        for index, area_full_code in enumerate(dataframe[col_area]):
            area_full_code = str(area_full_code)
            if len(area_full_code) < 4 or not area_full_code.isdigit():
                continue

            area_code = area_full_code[ :-3]

            # 현재 행의 버스정류장ARS 번호가 유효하다면 자치구 이름을 읽고
            if int(area_code) > len(areaCodes):
                continue
            area_name = areaCodes[str(area_code)]
            
            # 승하차 승객 수를 자치구별로 필터링하여 저장
            for col, passenger_counts in passenger_data.items():
                count = passenger_counts[index]

                if "승차" in col:
                    bus_usage["소계"]["in"] += count
                    bus_usage[area_name]["in"] += count

                elif "하차" in col:
                    bus_usage["소계"]["out"] += count
                    bus_usage[area_name]["out"] += count

        return bus_usage


    def subway(self) -> dict:
        """자치구별 지하철 승하차 데이터를 dict 형태로 반환하는 함수입니다."""

        dataframe = self.__dfReader.fromCsv("subway")
        if dataframe is None:
            return None

        # 자치구별 지하철 역 정보 읽기
        area_stations = configurator.subwayStation().readSeoul()

        # 승하차 인원 데이터 저장
        passenger_data = {}
        for column in dataframe.columns:
            if "인원" in column:
                passenger_data[column] = dataframe[column].values

        # 자치구 이름 읽고 값 초기화
        subway_usage = population().seoul()
        for key in subway_usage.keys():
            subway_usage[key] = {"in":0, "out":0}

        # 자치구별 지하철 이용 수 읽기 시작
        stations = dataframe["지하철역"].values
        for index, station in enumerate(stations):
            station = str(station)

            # "청량리(서울시립대입구)" 같은 역명 문자열을 "청량리"로 치환 (괄호 및 괄호 안 문자열 제거)
            bracket_index = station.find('(')
            if bracket_index > -1:
                station = station[ :bracket_index]

            # 현재 역이 포함된 자치구명 읽기
            area_name = ""
            for area, stations in area_stations.items():
                if station in stations:
                    area_name = area

            # 현재 행의 역이 서울시에 존재하지 않는 역이라면 스킵
            if len(area_name) < 2:
                continue

           # 승하차 승객 수를 자치구별로 필터링하여 저장
            for col, passenger_counts in passenger_data.items():
                count = passenger_counts[index]

                if "승차" in col:
                    subway_usage["소계"]["in"] += count
                    subway_usage[area_name]["in"] += count

                elif "하차" in col:
                    subway_usage["소계"]["out"] += count
                    subway_usage[area_name]["out"] += count

        return subway_usage