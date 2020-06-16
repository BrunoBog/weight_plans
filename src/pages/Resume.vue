<template>
  <div class="content">
   <weightCard/>
    <weightCard/>
  </div>
</template>

<script>
import weightCard from '../components/Card.vue'
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
  margin-top: 20px;
}
</style>