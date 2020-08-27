// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IQtyAdjustReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IQtyAdjustReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_LoadESigDetails_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Parameters parameters,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      QtyAdjustReasonMaintMethod[] methods,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      QtyAdjustReasonMaint qtyAdjustReasonMaint,
      QtyAdjustReasonMaint_Request request,
      out QtyAdjustReasonMaint_Result result);
  }
}
