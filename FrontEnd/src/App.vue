<template>
  <div id="app">
        <router-view/>
  </div>
</template>

<script>

export default {
  name: "App",
};
</script>

<style>
* {
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}
html {
  background-color: #f1faee;
}
body, html {
  padding: 0;
  margin: 0;
  background-color: #f1faee;
}

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}
</style>
