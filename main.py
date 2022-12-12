import visualizer

visual = visualizer.transport()

visual.addChartBar("population", "dailyrate", 0, "버스", "#ff0000")

visual.showCharts("서울시 대중교통 일일 이용률", "자치구", "일일 이용률(%)")
