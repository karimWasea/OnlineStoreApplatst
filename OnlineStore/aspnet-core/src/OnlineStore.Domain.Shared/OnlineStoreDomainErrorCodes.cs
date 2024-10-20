﻿namespace OnlineStore;

public static class OnlineStoreDomainErrorCodes
{
    public const string NAMESPACE = "Demo1.Products:";
    public const string PRODUCT_NOT_FOUND = NAMESPACE + "STORE_PRODUCTS_0001";
    public const string INVALID_PRODUCT_DATA_NAME_AR = NAMESPACE + "STORE_PRODUCTS_0002";
    public const string INVALID_PRODUCT_DATA_NAME_EN = NAMESPACE + "STORE_PRODUCTS_0003";
    public const string INVALID_PRODUCT_DATA_DESC_AR = NAMESPACE + "STORE_PRODUCTS_0004";
    public const string INVALID_PRODUCT_DATA_DESC_EN = NAMESPACE + "STORE_PRODUCTS_0005";
    public const string INVALID_PRODUCT_CATEGORY = NAMESPACE + "STORE_PRODUCTS_0006";
    public const string PRODUCT_ALREADY_EXISTS = NAMESPACE + "STORE_PRODUCTS_0007";
}
