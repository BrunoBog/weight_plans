<template>
  <div id="chart" class="chart">
    <apexchart type="line" height="350" :options="chartOptions" :series="series"></apexchart>
  </div>
</template>

<script>
import VueApexCharts from "vue-apexcharts";

export default {
  props: ["weightDataSeries", "dataLabels", "period", "bDataSerie"],
  name: "LineChart",
  components: {
    apexchart: VueApexCharts
  },
  data() {
    return {
      wightvalues: [],
      bfvalues: [] ,
      data_series: [],
      series: [
        {
          name: "Weight",
          data: this.wightvalues
        },
        {
          name: "Bf",
          data: this.bfvalues
        }
      ],
      chartOptions: {
        chart: {
          type: "line"
        },
        stroke: {
          width: 7,
          curve: "smooth"
        },
        xaxis: {
          type: "datetime",
          categories: this.data_series
        },
        title: {
          text: "Social Media",
          align: "left",
          style: {
            fontSize: "16px",
            color: "#666"
          }
        },
        fill: {
          type: "gradient",
          gradient: {
            shade: "dark",
            gradientToColors: ["#A8DADC2", "#E63946"],
            shadeIntensity: 1,
            type: "horizontal",
            opacityFrom: 1,
            opacityTo: 1,
            stops: [0, 100, 100, 100]
          }
        },
        markers: {
          size: 4,
          colors: ["#FFA41B"],
          strokeColors: "#fff",
          strokeWidth: 2,
          hover: {
            size: 7
          }
        },
        yaxis: {
          min: -10,
          max: 150,
          title: {
            text: "Engagement"
          }
        }
      }
    };
  },
  beforeMount() {
      this.get_values()
  },
  methods:{
    async get_values(){
    try {  
      let resp = await this.$http({ 
          url: this.$config.base_url + 'v1/weight', 
          method: 'GET' 
          })
      let bfs = resp.data.map( i => i.bodyFatValue)
      let weights = resp.data.map( i => i.weightValue)
      let dates = resp.data.map( i => i.day)

      this.data_series = dates,
      this.wightvalues = weights
      this.bfvalues = bfs
      //TODO refresh Hero
    } catch (error) {
      console.log(error)
    }
    }
  }
};
</script>

<style scoped>
.chart {
  margin-left: 30px;
  margin-right: 30px;
  min-width: 700px;
  padding: 10px;
  display: flex;
  background-color: #f1faee;
  border-radius: 25px;
}
</style>