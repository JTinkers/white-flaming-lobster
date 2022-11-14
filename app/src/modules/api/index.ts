import { App } from 'vue';
import ISampleRequest from './structures/ISampleRequest';

export { ISampleRequest }

const module =
{
    install(app: App)
    {
        // setup api client provider, like urql, axios etc. here
    }
};

export default module;