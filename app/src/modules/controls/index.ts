import { App } from 'vue';
import SampleControl from 'SampleControl.vue';

// you can plug any controls here to make them globally available

const module =
{
    install(app: App)
    {
        app.component('SampleControl', SampleControl);
    }
};

export default module;