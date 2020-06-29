<template>
  <div id="chart" class="chart">
    <apexchart type="line" height="350" :options="chartOptions" :series="series"></apexchart>
  </div>
</template>

<script>
import VueApexCharts from "vue-apexcharts";

export default {
  props: ["dataSeries", "dataLabels", "period"],
    name: 'LineChart',
    components: {
        apexchart: VueApexCharts
    },
    data(){
    return {
          series: [{
            name: 'Weight',
            data: [4, 3, 10, 9, 29, 19, 22, 9, 12, 7, 19, 5, 13, 9, 17, 2, 7, 5], 
          },
          {
            name: 'Bf',
            data: [9, 21, 16, 20, 30, 49, 52, 10, 2, 17, 29, 15, 3, 9, 67, 2, 7, 5], 
          }],
          chartOptions: {
            chart: {
              type: 'line',
            },
            stroke: {
              width: 7,
              curve: 'smooth'
            },
            xaxis: {
              type: 'datetime',
              categories: ['1/11/2000', '2/11/2000', '3/11/2000', '4/11/2000', '5/11/2000', '6/11/2000', '7/11/2000', '8/11/2000', '9/11/2000', '10/11/2000', '11/11/2000', '12/11/2000', '1/11/2001', '2/11/2001', '3/11/2001','4/11/2001' ,'5/11/2001' ,'6/11/2001'],
            },
            title: {
              text: 'Social Media',
              align: 'left',
              style: {
                fontSize: "16px",
                color: '#666'
              }
            },
            fill: {
              type: 'gradient',
              gradient: {
                shade: 'dark',
                gradientToColors: [ '#FDD835','#545454'],
                shadeIntensity: 1,
                type: 'horizontal',
                opacityFrom: 1,
                opacityTo: 1,
                stops: [0, 100, 100, 100]
              },
            },
            markers: {
              size: 4,
              colors: ["#FFA41B"],
              strokeColors: "#fff",
              strokeWidth: 2,
              hover: {
                size: 7,
              }
            },
            yaxis: {
              min: -10,
              max: 150,
              title: {
                text: 'Engagement',
              },
            }
          },
        }
    },
}
</script>

<style scoped>
.chart{
  margin-left: 30px;
  margin-right: 30px;
  display: flex;
  background-color: #F1FAEE;
  border-radius: 25px;
}
</style>