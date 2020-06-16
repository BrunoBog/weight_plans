<template>
  <div class="card">
      <!-- <input type="text" name="weight" v-bind="weightValue"> -->
      <a href="#" class="button">Send</a>
  </div>
</template>

<script>
export default {
  name: "weightCard",
  data(){
      return{
      weightValue : 0
      }
  }
};
</script>

<style scoped>
.card{
    background-color: #465775;
    max-width: 350px;
    max-height: 170px;
    border: none;
    border-radius: 25px;
}

</style>