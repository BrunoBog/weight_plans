<template>
  <div id="chart" class="chart">
    <apexchart type="line" height="350" :options="chartOptions" :series="series"></apexchart>
  </div>
</template>

<script>
import VueApexCharts from "vue-apexcharts";

export default {
  props: ["weightDataSeries", "dataLabels", "period", "bDataSerie"],
    name: 'LineChart',
    components: {
        apexchart: VueApexCharts
    },
    data(){
    return {
          series: [{
            name: 'Weight',
            data: [], 
          },
          {
            name: 'Bf',
            data: [], 
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
                gradientToColors: [ '#A8DADC2','#E63946'],
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
  min-width: 700px;
  padding: 10px;
  display: flex;
  background-color: #F1FAEE;
  border-radius: 25px;
}
</style>