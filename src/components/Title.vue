<template>
  <div class="topbar">
    <div class="img">
      <img src="@/img/weight.svg"/>
      
    </div>
    <div class="Title">Weight Control</div>
  </div>
</template>

<script>
export default {
  name: "TitleBar",
  
};
</script>

<style  scoped>
.topbar {
  display: flex;
  justify-content: flex-start;
}
.Title {
  flex-grow: 4;
  color: #fcfffd;
  padding: 9px;
}
</style>