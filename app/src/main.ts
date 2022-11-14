import { createApp } from 'vue'
import App from './App.vue'
import router from '@/modules/router'
import store from '@/modules/store'
import controls from '@/modules/controls';

createApp(App)
    .use(store)
    .use(router)
    .use(controls)
    .mount('#app')
