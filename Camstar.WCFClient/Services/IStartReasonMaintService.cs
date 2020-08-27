// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IStartReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IStartReasonMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      StartReasonMaint startReasonMaint,
      StartReasonMaint_LoadESigDetails_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Parameters parameters,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      StartReasonMaintMethod[] methods,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      StartReasonMaint startReasonMaint,
      StartReasonMaint_Request request,
      out StartReasonMaint_Result result);
  }
}
