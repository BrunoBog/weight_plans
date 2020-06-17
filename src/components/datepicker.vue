<template>
  <div class="picker">
    <VueTailwindPicker>
      <img src="../img/icons/calendario.png" alt="Calend" />
      <!-- <input type="text" v-model="checkin" /> -->
    </VueTailwindPicker>
  </div>
</template>

<script>
import VueTailwindPicker from "vue-tailwind-picker";
import 'dayjs'
export default {
  name: "DatePicker",
  components: {
    VueTailwindPicker
  }
};
</script>

<style scoped>

</style>