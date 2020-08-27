// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUserCodeGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUserCodeGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_LoadESigDetails_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Parameters parameters,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UserCodeGroupMaintMethod[] methods,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UserCodeGroupMaint userCodeGroupMaint,
      UserCodeGroupMaint_Request request,
      out UserCodeGroupMaint_Result result);
  }
}
