<template>
  <div class="content">
   <weightCard/>
    <!--TODO: <GraphCard/> -->
  </div>
</template>

<script>
import weightCard from '../components/WeightCard.vue'
export default {
  name: "resume",
  components: {weightCard}
};
</script>

<style scoped>
.content {
  display: flex;
  flex-direction: row;
  justify-content: space-around;
  margin-top: -40px;
}
</style>