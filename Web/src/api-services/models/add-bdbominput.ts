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
 * @interface AddBDBOMInput
 */
export interface AddBDBOMInput {
    /**
     * 
     * @type {string}
     * @memberof AddBDBOMInput
     */
    bomId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AddBDBOMInput
     */
    orgId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AddBDBOMInput
     */
    masterPartId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AddBDBOMInput
     */
    subPartId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AddBDBOMInput
     */
    rootPartId?: string | null;
    /**
     * 
     * @type {number}
     * @memberof AddBDBOMInput
     */
    needQty?: number;
    /**
     * 
     * @type {number}
     * @memberof AddBDBOMInput
     */
    subProductType?: number;
    /**
     * 
     * @type {number}
     * @memberof AddBDBOMInput
     */
    level?: number;
    /**
     * 
     * @type {string}
     * @memberof AddBDBOMInput
     */
    bomPath?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AddBDBOMInput
     */
    opNo?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AddBDBOMInput
     */
    upperLayerBomid?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AddBDBOMInput
     */
    partBomId?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AddBDBOMInput
     */
    slevel?: string | null;
    /**
     * 
     * @type {string}
     * @memberof AddBDBOMInput
     */
    mlevel?: string | null;
    /**
     * 
     * @type {number}
     * @memberof AddBDBOMInput
     */
    masterPartType?: number;
    /**
     * 
     * @type {number}
     * @memberof AddBDBOMInput
     */
    subPartType?: number;
    /**
     * 
     * @type {Date}
     * @memberof AddBDBOMInput
     */
    startTime?: Date;
    /**
     * 
     * @type {Date}
     * @memberof AddBDBOMInput
     */
    stopTime?: Date;
    /**
     * 
     * @type {string}
     * @memberof AddBDBOMInput
     */
    availableLine?: string | null;
}
