// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISellReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISellReasonGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_LoadESigDetails_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Parameters parameters,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SellReasonGroupMaintMethod[] methods,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SellReasonGroupMaint sellReasonGroupMaint,
      SellReasonGroupMaint_Request request,
      out SellReasonGroupMaint_Result result);
  }
}
