using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;

/*
namespace NSRMCommon {
    
    
    
    /// <summary>class TradeItemDist</summary>
    /// <remarks>Generated by user 'rik' on machine 'rik-PC' on 27-Aug-15 07:43:41</remarks>
    /// 
    [Obsolete("don't use this anymore",true)]
    public class CSTradeItemDist {

        #region ctor



        public CSTradeItemDist(System.Data.IDataReader reader) {
            for (int i = 0;(i < reader.FieldCount);i++) {
                if (reader.IsDBNull(i)) continue;

                switch (reader.GetName(i)) {
                    case "dist_num": this.distNum = reader.GetInt32(i); break;
                    case "trade_num": this.tradeNum = reader.GetInt32(i); break;
                    case "order_num": this.orderNum = reader.GetInt16(i); break;
                    case "item_num": this.itemNum = reader.GetInt16(i); break;
                    case "accum_num": this.accumNum = reader.GetInt16(i); break;
                    case "qpp_num": this.qppNum = reader.GetInt16(i); break;
                    case "pos_num": this.posNum = reader.GetInt32(i); break;
                    case "real_port_num": this.realPortNum = reader.GetInt32(i); break;
                    case "dist_type": this.distType = reader.GetString(i).Trim(); break;
                    case "real_synth_ind": this.realSynthInd = reader.GetString(i).Trim(); break;
                    case "is_equiv_ind": this.isEquivInd = reader.GetString(i).Trim(); break;
                    case "what_if_ind": this.whatIfInd = reader.GetString(i).Trim(); break;
                    case "bus_date": this.busDate = reader.GetDateTime(i); break;
                    case "p_s_ind": this.pSInd = reader.GetString(i).Trim(); break;
                    case "dist_qty": this.distQty = reader.GetDouble(i); break;
                    case "alloc_qty": this.allocQty = reader.GetDouble(i); break;
                    case "discount_qty": this.discountQty = reader.GetDouble(i); break;
                    case "priced_qty": this.pricedQty = reader.GetDouble(i); break;
                    case "qty_uom_code": this.qtyUomCode = reader.GetString(i).Trim(); break;
                    case "qty_uom_code_conv_to": this.qtyUomCodeConvTo = reader.GetString(i).Trim(); break;
                    case "qty_uom_conv_rate": this.qtyUomConvRate = reader.GetDouble(i); break;
                    case "price_curr_code_conv_to": this.priceCurrCodeConvTo = reader.GetString(i).Trim(); break;
                    case "price_curr_conv_rate": this.priceCurrConvRate = reader.GetDouble(i); break;
                    case "price_uom_code_conv_to": this.priceUomCodeConvTo = reader.GetString(i).Trim(); break;
                    case "price_uom_conv_rate": this.priceUomConvRate = reader.GetDouble(i); break;
                    case "spread_pos_group_num": this.spreadPosGroupNum = reader.GetInt32(i); break;
                    case "delivered_qty": this.deliveredQty = reader.GetDouble(i); break;
                    case "open_pl": this.openPl = reader.GetDouble(i); break;
                    case "pl_asof_date": this.plAsofDate = reader.GetDateTime(i); break;
                    case "closed_pl": this.closedPl = reader.GetDouble(i); break;
                    case "addl_cost_sum": this.addlCostSum = reader.GetDouble(i); break;
                    case "sec_conversion_factor": this.secConversionFactor = reader.GetDouble(i); break;
                    case "sec_qty_uom_code": this.secQtyUomCode = reader.GetString(i).Trim(); break;
                    case "commkt_key": this.commktKey = reader.GetInt32(i); break;
                    case "trading_prd": this.tradingPrd = reader.GetString(i).Trim(); break;
                    case "trans_id": this.transId = reader.GetInt32(i); break;
                    case "estimate_qty": this.estimateQty = reader.GetDecimal(i); break;
                    case "formula_num": this.formulaNum = reader.GetInt32(i); break;
                    case "formula_body_num": this.formulaBodyNum = reader.GetInt32(i); break;
                }
            }
        }
        #endregion

        #region properties
        [DisplayName("Dist Num")]
        public int distNum { get; set; }
        [DisplayName("Trade Num")]
        public int tradeNum { get; set; }
        [DisplayName("Order Num")]
        public short orderNum { get; set; }
        [DisplayName("Item Num")]
        public short itemNum { get; set; }
        [DisplayName("Accumn Num")]
        public short accumNum { get; set; }
        [DisplayName("QPP Num")]
        public short qppNum { get; set; }
        [DisplayName("P/S")]
        public string pSInd { get; set; }
        [DisplayName("Dist Type")]
        public string distType { get; set; }
        [DisplayName("Real/Synth")]
        public string realSynthInd { get; set; }
        [DisplayName("Equiv Ind")]
        public string isEquivInd { get; set; }
        [DisplayName("Commkt")]
        public int commktKey { get; set; }
        [DisplayName("Trading Prd")]
        public string tradingPrd { get; set; }
        [DisplayName("Dist Quantity")]
        public double distQty { get; set; }
        [DisplayName("Alloc Quantity")]
        public double allocQty { get; set; }
        [DisplayName("Del Quantity")]
        public double deliveredQty { get; set; }
        [DisplayName("Disc Quantity")]
        public double discountQty { get; set; }
        [DisplayName("Uom")]
        public string qtyUomCode { get; set; }
        [DisplayName("Conv Rate")]
        public double priceCurrConvRate { get; set; }
        [DisplayName("Uom Conv To")]
        public string priceUomCodeConvTo { get; set; }
        [DisplayName("Sec Conv Rate")]
        public double secConversionFactor { get; set; }
        [DisplayName("Sec Uom")]
        public string secQtyUomCode { get; set; }
        [DisplayName("Priced Qty")]
        public double pricedQty { get; set; }
        [DisplayName("Priced Curr Conv")]
        public string priceCurrCodeConvTo { get; set; }

        [DisplayName("qtyUomConvRate")]
        public double qtyUomConvRate { get; set; }

        [DisplayName("priceUomConvRate")]
        public double priceUomConvRate { get; set; }
        [DisplayName("Business Date")]
        public DateTime busDate { get; set; }
        [DisplayName("Pos Num")]
        public int posNum { get; set; }
        [DisplayName("Port Num")]
        public int realPortNum { get; set; }

        [DisplayName("Spread")]
        public int spreadPosGroupNum { get; set; }

        [DisplayName("Est Qty")]
        public decimal estimateQty { get; set; }

        [DisplayName("WhatIfInd")]
        public string whatIfInd { get; set; }
        [DisplayName("QtyUomCodeConvTo")]
        public string qtyUomCodeConvTo { get; set; }
        [DisplayName("OpenPl")]
        public double openPl { get; set; }
        [DisplayName("PLAsofDate")]
        public DateTime plAsofDate { get; set; }
        [DisplayName("ClosedPl")]
        public double closedPl { get; set; }
        [DisplayName("AddlCostSum")]
        public double addlCostSum { get; set; }
        [DisplayName("TransId")]
        public int transId { get; set; }
        [DisplayName("FormulaNum")]
        public int formulaNum { get; set; }
        [DisplayName("FormulaBodyNum")]
        public int formulaBodyNum { get; set; }
        #endregion

        [Obsolete("use java-version",false)]
        public static CSTradeItemDist[] distributionsForPosnums(int[] posNums) {
            //            new 
            string connStr,query;
            List<CSTradeItemDist> tmp = new List<CSTradeItemDist>();

            connStr = ConnectionUtil.dotNetConnectionString();
            query = "SELECT * FROM trade_item_dist WHERE " + DBUtil.makeEqualOrInClause(posNums,"pos_num");
            Debug.Print("distributions: " + query);
            try {
                using (SqlConnection conn = new SqlConnection(connStr)) {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query,conn)) {
                        using (SqlDataReader reader = cmd.ExecuteReader()) {
                            while (reader.Read())
                                tmp.Add(new CSTradeItemDist(reader));
                        }
                    }
                    conn.Close();
                }
            } catch (Exception ex) {
                NSRMLogging.Util.show(
                    MethodBase.GetCurrentMethod(),
                    "[" + ex.GetType().FullName + "] " + ex.Message +
                    "\r\nConnection=" + connStr + "\r\nQuery=" + query);
            }
            return tmp.ToArray();
        }
    }
}
    */