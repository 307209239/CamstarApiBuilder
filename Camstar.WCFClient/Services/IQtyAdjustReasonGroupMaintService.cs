// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IQtyAdjustReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IQtyAdjustReasonGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_LoadESigDetails_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Parameters parameters,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      QtyAdjustReasonGroupMaintMethod[] methods,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      QtyAdjustReasonGroupMaint qtyAdjustReasonGroupMaint,
      QtyAdjustReasonGroupMaint_Request request,
      out QtyAdjustReasonGroupMaint_Result result);
  }
}
