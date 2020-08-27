// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUserQueryMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUserQueryMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UserQueryMaint userQueryMaint,
      UserQueryMaint_LoadESigDetails_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Parameters parameters,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UserQueryMaintMethod[] methods,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UserQueryMaint userQueryMaint,
      UserQueryMaint_Request request,
      out UserQueryMaint_Result result);
  }
}
