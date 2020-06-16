<template>
  <div class="boxHero">
      <div class="header"></div>
      <div class="principal">99,2 Kg</div>
      <div class="footer"></div>
  </div>
</template>

<script>
export default {
    name: 'Hero'
}
</script>

<style>
    .boxHero{
        display: flex;
        align-content: ba;
        flex-direction: column;
        color:#E96544;
        /* background-image: image('../img/intro.jpg'); */
        background-image: linear-gradient(to right, #465775, #67AD86);
    }
    .principal{
        font-size: 99px;
    }
</style>