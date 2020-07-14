import Vue from 'vue'
import App from './App.vue'
import './registerServiceWorker'
import router from './router'
import store from './store'
import VueApexCharts from 'vue-apexcharts'
import Axios from 'axios'
import Config from './Config.js'


Vue.config.productionTip = false
Vue.component('apexchart', VueApexCharts)
Vue.prototype.$http = Axios;
Vue.prototype.$config = Config;
localStorage.setItem('config', Config);

Vue.prototype.$http.defaults.headers.common['Access-Control-Allow-Origin'] = '*'

const token = localStorage.getItem('token')
if (token){
  Vue.prototype.$http.defaults.headers.common['Authorization'] = "Bearer "  + ('');
}

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
