<template>
  <div id="chart" class="chart">
    <apexchart type="line" :options="options" :series="series"></apexchart>
  </div>
</template>

<script>
import VueApexCharts from "vue-apexcharts";

export default {
  name: "LineChart",
  components: {
    apexchart: VueApexCharts,
  },
  data() {
    return {
      labels: [new Date()],
      options: {
        chart: {
          id: "vuechart-example",
        },
        xaxis: {
          // type: 'datetime',
          // categories: ['1/11/2000', '2/11/2000', '3/11/2000', '4/11/2000', '5/11/2000', '6/11/2000', '7/11/2000', '8/11/2000', '9/11/2000', '10/11/2000', '11/11/2000', '12/11/2000', '1/11/2001', '2/11/2001', '3/11/2001','4/11/2001' ,'5/11/2001' ,'6/11/2001'],
        },
        stroke: {
          width: 7,
          curve: "smooth",
        },
        title: {
              text: 'Weight Values',
              align: 'left',
              style: { fontSize: "16px", color: '#666' }
        },
        fill: {
              type: 'gradient',
              gradient: {
                shade: 'dark',
                gradientToColors: [ '#FDD835'],
                shadeIntensity: 1,
                type: 'horizontal',
                opacityFrom: 1,
                opacityTo: 1,
                stops: [0, 100, 100, 100]
              },
            }
      },
      series: [
        {
          name: "series-1",
          data: [],
        },
      ],
    };
  },
  beforeMount() {
    this.get_values();
  },
  methods: {
    async get_values() {
      try {
        let resp = await this.$http({
          url: this.$config.base_url + "v1/weight",
          method: "GET",
        });
        // let bfs = resp.data.map((i) => i.bodyFatValue);
        let weights = resp.data.map((i) => i.weightValue);
        let dates = resp.data.map((i) => i.day);

        // this.labels = dates;
        // this.xaxis.categories = resp.data.map((i) => i.day.toString())
        // {
        //   type: 'datetime',
        //   categories: ['1/11/2000', '2/11/2000', '3/11/2000', '4/11/2000', '5/11/2000', '6/11/2000', '7/11/2000', '8/11/2000', '9/11/2000', '10/11/2000', '11/11/2000', '12/11/2000', '1/11/2001', '2/11/2001', '3/11/2001','4/11/2001' ,'5/11/2001' ,'6/11/2001'],
        // }

        // {
        //   type: 'datetime',
        //   categories: dates,
        // }
        

        this.updateTheme(dates);
        this.series = [
          {
            name: "Weight value:",
            data: weights,
          },
          // {
          //   name: "BF value:",
          //   data: bfs
          // }
        ];

        // (this.data_series = dates), (this.wightvalues = weights) this.bfvalues = bfs;
        //TODO refresh Hero
      } catch (error) {
        console.log(error);
      }
    },
    updateTheme(date) {
      this.chartOptions = {
        xaxis: {
          categories: date,
        },
      };
    },
  },
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