import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'OnlineStore',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44373/',
    redirectUri: baseUrl,
    clientId: 'OnlineStore_App',
    responseType: 'code',
    scope: 'offline_access OnlineStore',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44373',
      rootNamespace: 'OnlineStore',
    },
  },
} as Environment;
