// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRoleMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRoleMaintService
  {
    [OperationContract]
    ResultStatus AddMembers(
      UserProfile userProfile,
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result);

    [OperationContract]
    ResultStatus AddPermissions(
      UserProfile userProfile,
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result);

    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result);

    [OperationContract]
    ResultStatus DeleteMembers(
      UserProfile userProfile,
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result);

    [OperationContract]
    ResultStatus DeletePermissions(
      UserProfile userProfile,
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RoleMaint roleMaint,
      RoleMaint_LoadESigDetails_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RoleMaintMethod[] methods,
      RoleMaint_Request request,
      out RoleMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RoleMaint roleMaint,
      RoleMaint_Request request,
      out RoleMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RoleMaint roleMaint,
      RoleMaint_Request request,
      out RoleMaint_Result result);
  }
}
