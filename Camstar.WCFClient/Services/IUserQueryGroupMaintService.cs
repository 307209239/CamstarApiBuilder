// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUserQueryGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUserQueryGroupMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_LoadESigDetails_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Parameters parameters,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UserQueryGroupMaintMethod[] methods,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UserQueryGroupMaint userQueryGroupMaint,
      UserQueryGroupMaint_Request request,
      out UserQueryGroupMaint_Result result);
  }
}
