// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRolePermissionsMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRolePermissionsMaintService
  {
    [OperationContract]
    ResultStatus AddPermissions(
      UserProfile userProfile,
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_AddPermissions_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result);

    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result);

    [OperationContract]
    ResultStatus DeletePermissions(
      UserProfile userProfile,
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_LoadESigDetails_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RolePermissionsMaintMethod[] methods,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result);
  }
}
