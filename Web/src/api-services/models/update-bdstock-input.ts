/* tslint:disable */
/* eslint-disable */
/**
 * 业务应用
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */
/**
 * 
 * @export
 * @interface UpdateBDStockInput
 */
export interface UpdateBDStockInput {
    /**
     * 
     * @type {string}
     * @memberof UpdateBDStockInput
     */
    stockId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UpdateBDStockInput
     */
    partID?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UpdateBDStockInput
     */
    partNo?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UpdateBDStockInput
     */
    partDesc?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UpdateBDStockInput
     */
    orgID?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UpdateBDStockInput
     */
    batch?: string | null;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    maxStock?: number;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    minStock?: number;
    /**
     * 
     * @type {string}
     * @memberof UpdateBDStockInput
     */
    prodMode?: string | null;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    availableStock?: number;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    currentStock?: number;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    errorRate?: number;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    sourceType?: number;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    promiseDate?: number;
    /**
     * 
     * @type {string}
     * @memberof UpdateBDStockInput
     */
    subInventoryCode?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UpdateBDStockInput
     */
    locator?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UpdateBDStockInput
     */
    location?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UpdateBDStockInput
     */
    subLocation?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UpdateBDStockInput
     */
    bin?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UpdateBDStockInput
     */
    lot?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UpdateBDStockInput
     */
    serial?: string | null;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    atpQty?: number;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    committedQty?: number;
    /**
     * 
     * @type {boolean}
     * @memberof UpdateBDStockInput
     */
    isBad?: boolean;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    allocatedQTY?: number;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    availableQOH?: number;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    safetyStock?: number;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    leadTime?: number;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    shortageQty?: number;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    inventoryCalculation?: number;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    isRawMaterial?: number;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    lotSize?: number;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    scrap?: number;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    deburring?: number;
    /**
     * 
     * @type {string}
     * @memberof UpdateBDStockInput
     */
    minOp?: string | null;
    /**
     * 
     * @type {string}
     * @memberof UpdateBDStockInput
     */
    powderType?: string | null;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    gpLotSize?: number;
    /**
     * 
     * @type {number}
     * @memberof UpdateBDStockInput
     */
    id: number;
}
