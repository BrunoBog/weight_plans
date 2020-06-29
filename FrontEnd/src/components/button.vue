<template>
  <button v-on:click.stop="callparent">
    <span class="printicon">SEND</span>
  </button>
</template>

<script>
export default {
  name: "Butt",
  props: ["Label"],
  methods:{
    callparent(){
      this.$emit('On_click')
    }
  },
  data() {
      return {
        label: this.Label
      }
  }
};
</script>

<style>
button {
  position: relative;
  outline: none;
  text-decoration: none;
  border-radius: 50px;
  display: flex;
  justify-content: center;
  align-items: center;
  cursor: pointer;
  text-transform: uppercase;
  height: 60px;
  width: 59px;
  opacity: 1;
  background-color: #A8DADC;
  border: 1px solid #A8DADC; 
}

button span {
  color: #164ca7;
  font-size: 12px;
  font-weight: 500;
  letter-spacing: 0.7px;
}

button:hover {
  animation: rotate 0.7s ease-in-out both;
}

button:hover span {
  animation: storm 0.7s ease-in-out both;
  animation-delay: 0.06s;
}

@keyframes rotate {
  0% {
    transform: rotate(0deg) translate3d(0, 0, 0);
  }

  25% {
    transform: rotate(3deg) translate3d(0, 0, 0);
  }

  50% {
    transform: rotate(-3deg) translate3d(0, 0, 0);
  }

  75% {
    transform: rotate(1deg) translate3d(0, 0, 0);
  }

  100% {
    transform: rotate(0deg) translate3d(0, 0, 0);
  }
}

@keyframes storm {
  0% {
    transform: translate3d(0, 0, 0) translateZ(0);
  }

  25% {
    transform: translate3d(4px, 0, 0) translateZ(0);
  }

  50% {
    transform: translate3d(-3px, 0, 0) translateZ(0);
  }

  75% {
    transform: translate3d(2px, 0, 0) translateZ(0);
  }

  100% {
    transform: translate3d(0, 0, 0) translateZ(0);
  }
}

.printicon {
  display: flex;
  width: 25px;
  height: 50px;
  align-items: center;
  justify-content: center;
  color: #1D3557;
  font-weight: bold;
}
</style>