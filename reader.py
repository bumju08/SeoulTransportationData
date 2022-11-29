import pandas, pandas.core.frame
import os


class dataframe:
    """여러가지 형태의 데이터를 pandas DataFrame 형태로 변환하는 클래스입니다."""

    def __init__(self):
        self.encodings = ['utf-8', 'cp949', 'euc-kr']
        self.dbDir = "./db"

    def fromCsv(self, dataType: str) -> pandas.core.frame.DataFrame:
        """csv 파일을 읽어 pandas DataFrame으로 변환하여 반환하는 함수입니다.
        
        dataType: 읽어들일 csv 파일의 숫자, 특수문자, 확장자를 제외한 이름입니다."""
        dbDir = self.dbDir
        filePath = ""

        if len(dataType) == 0:
            return None

        if not os.path.isdir(dbDir):
            return None

        # db 폴더에서 각 파일들 중 조건에 부합하는 이름을 가진 파일만 추출 
        files = os.listdir(dbDir)
        validFiles = []
        for fileName in files:
            if not fileName.endswith(".csv"):
                continue

            fileName_OnlyAlpha = ''.join( [char for char in fileName if char.isalpha()] )[: -3]
            if fileName_OnlyAlpha.lower() == dataType.lower():
                validFiles.append(fileName)

        # 만약 같은 특성의 이름을 가진 파일이 존재하면 마지막 수정 날짜를 기준으로 선별
        latest_name = ""
        latest_time = 0
        if len(validFiles) > 0:
            for fileName in validFiles:
                last_modified_time = os.path.getmtime(dbDir + '/' + fileName)

                if last_modified_time > latest_time:
                    latest_time = last_modified_time
                    latest_name = fileName
        
        else:
            return None
        
        filePath = dbDir + '/' + fileName

        # 각 데이터 파일마다 인코딩 형식이 제각각이기 때문에, 각각의 인코딩으로 시도해서 성공한 방법으로 읽어들이기
        for encoding in self.encodings:
            try:
                file_csv = pandas.read_csv(filePath, encoding=encoding, low_memory=False)
                return file_csv

            except UnicodeDecodeError:
                pass

        return None
