<template>
  <div class="content">
    <weightCard />
      <LineChart :weight_data="weightSeries" :data_label="dates" :serie=series v-if="dates" />
  </div>
</template>

<script>
import weightCard from "../components/WeightCard.vue";
import LineChart from "../components/LineChart.vue";

export default {
  name: "resume",
  components: {
    weightCard,
    LineChart,
  },
  data() {
    return {
      weightSeries:  [4, 3, 10, 9, 29, 19, 22, 9, 12, 7, 19, 5, 13, 9, 17, 2, 7, 5],
      // dates: [0,1],
      dates: [4, 3, 10, 9, 29, 19, 22, 9, 12, 7, 19, 5, 13, 9, 17, 2, 7, 5],
      series: []
    };
  },
  beforeMount() {
    // this.get_values()
  },
  mounted(){
    this.get_values()
  },
  methods: {
    async get_values() {
      try {
        let resp = await this.$http({
          url: this.$config.base_url + "v1/weight?userID=1",
          method: "GET",
        })

        this.weightSeries = resp.data.map((i) => i.weightValue)
        this.dates = resp.data.map((i) => i.day)

        this.series = [
          {
            name: "Weight value:",
            data: resp.data.map((i) => i.weightValue),
          },
          // {
          //   name: "BF value:",
          //   data: resp.data.map((i) => i.bodyFatValue),
          // },
        ];

        this.$forceUpdate()
      } catch (error) {
        console.log(error);
      }
    },
  },
};
</script>

<style scoped>
.content {
  display: flex;
  flex-direction: row;
  justify-content: space-around;
  margin-top: -40px;
  margin-left: 10px;
}
.wc {
  min-height: 50%;
}
</style>