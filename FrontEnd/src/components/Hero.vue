<template>
  <div class="boxHero">
      <!-- <div class="header"></div> -->
      <div>{{actualSize}} Kg</div>
      <!-- <div class="footer"></div> -->
  </div>
</template>

<script>
export default {
    name: 'Hero',
     props: ["actual_size"],
     data() {
         return {
             actualSize: this.actual_size ?? 0
         }
     }
}
</script>

<style>
    .boxHero{
        display: flex;
        align-items: center;
          justify-content: center;
        color:#E96544;
        background-image: linear-gradient(to right, #465775, #67AD86);
        max-height: 450px;
    }
    .boxHero div{
        font-size: 99px;
        width: 50%;
        height: 30%;
    }
</style>