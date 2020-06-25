<template>
  <div class="content">
   <weightCard/>
   <LineChart/>
    <!-- <GraphCard/> -->
  </div>
</template>

<script>
import weightCard from '../components/WeightCard.vue'
import LineChart from '../components/LineChart.vue'
// import axios from "axios";

export default {
  name: "resume",
  components: {weightCard, LineChart}
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
</style>