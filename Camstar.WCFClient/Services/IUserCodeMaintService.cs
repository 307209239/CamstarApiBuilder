// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUserCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUserCodeMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UserCodeMaint userCodeMaint,
      UserCodeMaint_LoadESigDetails_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Parameters parameters,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UserCodeMaintMethod[] methods,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UserCodeMaint userCodeMaint,
      UserCodeMaint_Request request,
      out UserCodeMaint_Result result);
  }
}
