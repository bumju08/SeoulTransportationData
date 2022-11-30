import matplotlib, matplotlib.pyplot as plt
import pandas, numpy
import datetime, calendar

import reader, miner, configurator





class transport:
    """서울시 대중교통 및 인구 데이터를 시각화할 수 있는 클래스입니다."""
    
    def __init__(self):
        self.__tpMiner = miner.transport()
        self.__popMiner = miner.population()

    @staticmethod
    def getDaysOfMonth() -> int:
        """이번 달이 총 며칠까지 있는지 반환하는 함수"""
        date = datetime.datetime.now()
        month_range = calendar.monthrange(date.year, date.month)

        return month_range[1]

    @staticmethod
    def sortDictByValue(data: dict, descending: bool = False) -> dict:
        """딕셔너리를 값을 기준으로 정렬하여 반환하는 함수
        
        descending: 값을 내림차순으로 정렬할지 여부입니다."""

        data = dict(sorted(data.items(), key=lambda x:x[1]))
        if descending:
            data = dict(reversed(data.items()))

        return data

    def createChartBar(self, dataModel: str, dataType: str, sortType: int, label: str, color_hex: str) -> dict:
        """시각화 차트에 사용할 바 데이터셋을 하나 생성합니다.
        
        dataModel: "bus", "subway", "population"
        dataType: "dailyrate", "all", "in", "out"
        sortType: 0=정렬 안함  1=오름차순  2=내림차순
        label: 차트 범례 이름
        color_hex: 바의 색상"""
        
        data = self.getData(dataModel, dataType, sortType)
        return { 'data':data, 'color_hex':color_hex, 'label':label }

    def showCharts(self, dataList: list, title: str, xLabel: str, yLabel: str) -> None:
        """정리된 dict 형태의 교통 데이터를 시각화하여 차트를 그리는 함수입니다.
        
        data: 시각화할 데이터의 정보들을 담은 list입니다. list 내의 각 원소에는 시각화할 dict 데이터가 필요하며, 'data', 'color_hex', 'label' key를 요구합니다.
        """

        # 한글깨짐 방지를 위한 폰트 설정 및 기본 설정
        fontPath = "C:/Windows/Fonts/ngulim.ttf"
        font = matplotlib.font_manager.FontProperties(fname=fontPath).get_name()
        matplotlib.rc("font", family=font)

        # 첫번째 바의 시작위치 조정
        x_start = 0; bar_width = 0.3
        data_length = len(dataList)
        if data_length > 1:
            x_start = -bar_width * (data_length / 2)

        fig, ax = plt.subplots(figsize=(20, 10), dpi=80)
        for index, data in enumerate(dataList):
            names = list(data['data'].keys())
            values = list(data['data'].values())
            
            align = 'edge'
            if data_length < 2:
                align = 'center'
                bar_width = 0.5
            
            ax.bar(numpy.arange(len(data['data'])) + x_start + (index * bar_width), values, tick_label=names, label=data['label'], color=data['color_hex'], edgecolor='lightgray', width=bar_width, align=align)
            
            for p in ax.patches:
                left, bottom, width, height = p.get_bbox().bounds
                ax.annotate("%.1f"%(height), (left+width/2, height*1.01), fontsize=10, ha='center')


        ax.grid(visible=True, axis='y', alpha=0.33, linestyle="--")
        
        ax.set_xlabel(xLabel, fontsize=15)
        ax.set_ylabel(yLabel, fontsize=15)
        ax.set_title(title, fontsize=24)
        ax.legend(fontsize=15)
        
        plt.get_current_fig_manager().set_window_title(title)
        plt.show()


    def getData(self, dataModel: str, dataType: str = "dailyrate", sortType: int = 0) -> dict:
        """주어진 교통 데이터를 시각화 함수에 사용할 수 있는 형태로 변환하는 함수입니다.

        dataModel: "subway":지하철, "bus":버스, "population":인구
        dataType: "dailyrate":일일 이용률, "all":전체 이용수, "in":승차 이용수, "out":하차 이용수
        sortType: 데이터 정렬 유형입니다. 0=안함  1=오름차순  2=내림차순
        """
        dataModel = dataModel.lower()
        dataType = dataType.lower()

        # 인구수 데이터를 원하는 경우 속도를 위해 먼저 처리하고 반환
        population = self.__popMiner.seoul()
        population.pop("소계", None)
        if dataModel == "population":
            return population

        # 교통 데이터 가져오기
        transport = {}
        if dataModel == "bus":
            transport = self.__tpMiner.bus()
        elif dataModel == "subway":
            transport = self.__tpMiner.subway()
        transport.pop("소계", None)
        
        # dataType 매개변수로 전달된 인자를 기준으로 값 결정
        for key, value in transport.items():
            if dataType == "dailyrate":
                transport[key] = (value['in'] + value['out']) / 2
                transport[key] = transport[key] / (population[key] * self.getDaysOfMonth()) * 100
            elif dataType == "all":
                transport[key] = value["in"] + value["out"]
            elif dataType == "in":
                transport[key] = value['in']
            elif dataType == "out":
                transport[key] = value["out"]

        # 정렬
        descending = False
        if sortType == 2:
            descending = True
        if sortType > 0:
            transport = self.sortDictByValue(transport, descending)

        return transport
