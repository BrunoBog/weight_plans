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
  name: "Hero",
  props: ["actual_size", "actual_bf"],
  data() {
    return {
      actualSize: this.actual_size ?? 0,
      actualBF: this.actual_bf ?? 0
    };
  }
};
</script>

<style>
.boxHero {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  min-height: 350px;
  color: #e96544;
  /* background-image: image('../img/intro.jpg'); */
  background-image: linear-gradient(to right, #1d3557, #457b9d, #e63946);
}
.boxHero div {
  width: 100%;
  height: 100%;
}
.principal{
    font-size: 99px;
}
.sub {
  font-size: 30px;
  width: 50%;
  height: 50%;
}
</style>