import Vue from 'vue'
import App from './App.vue'
import './registerServiceWorker'
import router from './router'
import store from './store'
import Axios from 'axios'
import Config from './Config.js'

Vue.config.productionTip = false
Vue.prototype.$http = Axios;
Vue.prototype.$config = Config;
localStorage.setItem('config', Config);

Vue.prototype.$http.defaults.headers.common['Access-Control-Allow-Origin'] = '*'

const token = localStorage.getItem('token')

if (token){
  Vue.prototype.$http.defaults.headers.common['Authorization'] = "Bearer "  + token;
}else{
  Vue.prototype.$http.defaults.headers.common['Authorization'] = "Bearer "  + ('');
}

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
