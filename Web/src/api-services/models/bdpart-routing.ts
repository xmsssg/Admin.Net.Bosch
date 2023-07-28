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
 * 产品工序版本
 * @export
 * @interface BDPartRouting
 */
export interface BDPartRouting {
    /**
     * 雪花Id
     * @type {number}
     * @memberof BDPartRouting
     */
    id?: number;
    /**
     * 创建时间
     * @type {Date}
     * @memberof BDPartRouting
     */
    createTime?: Date | null;
    /**
     * 更新时间
     * @type {Date}
     * @memberof BDPartRouting
     */
    updateTime?: Date | null;
    /**
     * 创建者Id
     * @type {number}
     * @memberof BDPartRouting
     */
    createUserId?: number | null;
    /**
     * 修改者Id
     * @type {number}
     * @memberof BDPartRouting
     */
    updateUserId?: number | null;
    /**
     * 软删除
     * @type {boolean}
     * @memberof BDPartRouting
     */
    isDelete?: boolean;
    /**
     * 产品工序版本Id
     * @type {string}
     * @memberof BDPartRouting
     */
    partRoutingID?: string | null;
    /**
     * 产品工序版本号
     * @type {string}
     * @memberof BDPartRouting
     */
    partRoutingNo?: string | null;
    /**
     * 产品工序版本名称
     * @type {string}
     * @memberof BDPartRouting
     */
    partRoutingName?: string | null;
    /**
     * 组织编码
     * @type {string}
     * @memberof BDPartRouting
     */
    orgId?: string | null;
    /**
     * 产品编码
     * @type {string}
     * @memberof BDPartRouting
     */
    partId?: string | null;
    /**
     * 是否标准
     * @type {number}
     * @memberof BDPartRouting
     */
    isStandard?: number;
}
