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
 * BOM表
 * @export
 * @interface BDBOM
 */
export interface BDBOM {
    /**
     * 雪花Id
     * @type {number}
     * @memberof BDBOM
     */
    id?: number;
    /**
     * 创建时间
     * @type {Date}
     * @memberof BDBOM
     */
    createTime?: Date | null;
    /**
     * 更新时间
     * @type {Date}
     * @memberof BDBOM
     */
    updateTime?: Date | null;
    /**
     * 创建者Id
     * @type {number}
     * @memberof BDBOM
     */
    createUserId?: number | null;
    /**
     * 修改者Id
     * @type {number}
     * @memberof BDBOM
     */
    updateUserId?: number | null;
    /**
     * 软删除
     * @type {boolean}
     * @memberof BDBOM
     */
    isDelete?: boolean;
    /**
     * BOMId
     * @type {string}
     * @memberof BDBOM
     */
    bomId?: string | null;
    /**
     * 组织Id
     * @type {string}
     * @memberof BDBOM
     */
    orgId?: string | null;
    /**
     * 主产品Id
     * @type {string}
     * @memberof BDBOM
     */
    masterPartId?: string | null;
    /**
     * 子产品Id
     * @type {string}
     * @memberof BDBOM
     */
    subPartId?: string | null;
    /**
     * 根产成品Id
     * @type {string}
     * @memberof BDBOM
     */
    rootPartId?: string | null;
    /**
     * 比例
     * @type {number}
     * @memberof BDBOM
     */
    needQty?: number | null;
    /**
     * 子产品类型
     * @type {number}
     * @memberof BDBOM
     */
    subProductType?: number | null;
    /**
     * 层级
     * @type {number}
     * @memberof BDBOM
     */
    level?: number | null;
    /**
     * 图纸链接
     * @type {string}
     * @memberof BDBOM
     */
    bomPath?: string | null;
    /**
     * 对应工序
     * @type {string}
     * @memberof BDBOM
     */
    opNo?: string | null;
    /**
     * 上层BOM Id
     * @type {string}
     * @memberof BDBOM
     */
    upperLayerBomid?: string | null;
    /**
     * PartBomId
     * @type {string}
     * @memberof BDBOM
     */
    partBomId?: string | null;
    /**
     * 子产品层级
     * @type {string}
     * @memberof BDBOM
     */
    slevel?: string | null;
    /**
     * 主产品层级
     * @type {string}
     * @memberof BDBOM
     */
    mlevel?: string | null;
    /**
     * 主产品类型
     * @type {number}
     * @memberof BDBOM
     */
    masterPartType?: number | null;
    /**
     * 子产品类型
     * @type {number}
     * @memberof BDBOM
     */
    subPartType?: number | null;
    /**
     * 可用开始时间
     * @type {Date}
     * @memberof BDBOM
     */
    startTime?: Date | null;
    /**
     * 可用结束时间
     * @type {Date}
     * @memberof BDBOM
     */
    stopTime?: Date | null;
    /**
     * 可用产线
     * @type {string}
     * @memberof BDBOM
     */
    availableLine?: string | null;
}
