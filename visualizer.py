import matplotlib, matplotlib.pyplot as plt
import pandas
import datetime, calendar

import reader, miner, configurator


class public:
    """시각화에 공용으로 사용되는 함수를 모은 정적 클래스입니다."""

    @staticmethod
    def showChart(data: dict, title: str, xLabel: str, yLabel: str, color_hex: str = "#e35f62"):
        """정리된 dict 형태의 교통 데이터를 시각화하여 차트를 그리는 함수입니다."""

        # 한글깨짐 방지를 위한 폰트 설정 및 기본 설정
        fontPath = "C:/Windows/Fonts/ngulim.ttf"
        font = matplotlib.font_manager.FontProperties(fname=fontPath).get_name()
        matplotlib.rc("font", family=font)

        names = list(data.keys())
        values = list(data.values())

        fig, ax = plt.subplots(figsize=(20, 10), dpi=80)
        ax.bar(range(len(data)), values, tick_label = names, color=color_hex, edgecolor="lightgray", width=0.45)
        ax.grid(visible=True, axis='y', alpha=0.33, linestyle="--")
        
        ax.set_xlabel(xLabel, fontsize=15)
        ax.set_ylabel(yLabel, fontsize=15)
        ax.set_title(title, fontsize=24)
        
        plt.get_current_fig_manager().set_window_title(title)
        plt.show()

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



class transport:
    """서울시 대중교통 및 인구 데이터를 시각화하는 클래스입니다."""
    
    def __init__(self):
        self.__tpMiner = miner.transport()
        self.__popMiner = miner.population()
        
        self.sortDescending = False
        """데이터를 내림차순으로 시각화할지의 여부입니다."""

    def __calcUsage(self, transport: dict, population: dict, dataType: str) -> dict:
        """주어진 교통 데이터를 여러가지 형태로 정리하여 dict 형태로 반환하는 함수입니다.

        transport: dict형 교통 데이터입니다.
        population: dict형 자치구별 인구수 데이터입니다.
        dataType: "dailyrate":일일 이용률, "all":전체 이용수, "in":승차 이용수, "out":하차 이용수
        sortDescending: 데이터를 내림차순으로 정렬할지 여부입니다. 기본값은 오름차순입니다.
        """

        dataType = dataType.lower()
        transport.pop("소계")
        population.pop("소계")

        # dataType 매개변수로 전달된 인자를 기준으로 값 결정
        for key, value in transport.items():
            if dataType == "dailyrate":
                transport[key] = (value['in'] + value['out']) / 2
                transport[key] = transport[key] / (population[key] * public.getDaysOfMonth()) * 100
            elif dataType == "all":
                transport[key] = value["in"] + value["out"]
            elif dataType == "in":
                transport[key] = value['in']
            elif dataType == "out":
                transport[key] = value["out"]

        transport = public.sortDictByValue(transport, self.sortDescending)

        return transport


    def showSubway(self, dataType: str, title: str, xLabel: str, yLabel: str) -> None:
        """지하철 데이터를 이용해 시각화하는 함수입니다.

        dataType: "dailyrate":일일 이용률, "all":전체 이용수, "in":승차 이용수, "out":하차 이용수
        sortDescending: 데이터를 내림차순으로 정렬할지 여부입니다. 기본값은 오름차순입니다.
        """
        population = self.__popMiner.seoul()
        data = self.__tpMiner.subway()
        data = self.__calcUsage(data, population, dataType)
 
        public.showChart(data, title, xLabel, yLabel)

    def showBus(self, dataType: str, title: str, xLabel: str, yLabel: str) -> None:
        """버스 데이터를 이용해 시각화하는 함수입니다.

        dataType: "dailyrate":일일 이용률, "all":전체 이용수, "in":승차 이용수, "out":하차 이용수
        sortDescending: 데이터를 내림차순으로 정렬할지 여부입니다. 기본값은 오름차순입니다.
        """
        population = self.__popMiner.seoul()
        data = self.__tpMiner.bus()
        data = self.__calcUsage(data, population, dataType)

        public.showChart(data, title, xLabel, yLabel)

    def showPopulation(self):
        """서울시 자치구별 인구수를 시각화하여 보여주는 함수입니다."""

        population = self.__popMiner.seoul()
        population.pop("소계")
        population = public.sortDictByValue(population, self.sortDescending)
 
        public.showChart(population, "서울시 자치구별 인구 수", "자치구", "인구")

