import Vue from 'vue'
import VueRouter from 'vue-router'
import login from '../views/Login.vue'

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'login',
    component: login
  },
  {
    path: '/login',
    name: 'loginPage',
    component: login
  },
  {
    path: '/home',
    name: 'Home',
    // route level code-splitting
    // this generates a separate chunk (about.[hash].js) for this route
    // which is lazy-loaded when the route is visited.
    component: () => import(/* webpackChunkName: "about" */ '../views/Home.vue')
  },
  {
    path: '/register',
    name: 'Register',

    component: () => import(/* webpackChunkName: "about" */ '../views/Register.vue')
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})


router.beforeEach((to, from, next) => {
  
  const publicPages = ['/login', '/register'];
  const authRequired = !publicPages.includes(to.path);

  if(to.fullPath == '/logout'){
    localStorage.setItem('token', '')
  }
  const loggedIn = localStorage.getItem('token');


  if (authRequired && (!loggedIn || loggedIn == 'invalid' )) {
    return next('/login');
  }

  next();
})

export default router
