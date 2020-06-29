<template>
  <div class="boxHero">
      <div class="header"></div>
      <div class="principal">{{actualSize}} Kg</div>
      <div class="sub">{{actualSize}}% Bf</div>
      <div class="footer"></div>
  </div>
</template>

<script>
export default {
    name: 'Hero',
     props: ["actual_size", "actual_bf"],
     data() {
         return {
             actualSize: this.actual_size ?? 0,
             actualBF: this.actual_bf ?? 0
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
        /* background-image: image('../img/intro.jpg'); */
        background-image: linear-gradient(to right, #1D3557, #457B9D, #E63946);
    }
    .boxHero div{
        font-size: 99px;
        width: 50%;
        height: 30%;
    }
    .sub{
        font-size: 30px;
    }
</style>