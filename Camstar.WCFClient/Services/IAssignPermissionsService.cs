// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IAssignPermissionsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IAssignPermissionsService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      AssignPermissions assignPermissions,
      AssignPermissions_Parameters parameters,
      AssignPermissions_Request request,
      out AssignPermissions_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      AssignPermissions assignPermissions,
      AssignPermissions_Parameters parameters,
      AssignPermissions_Request request,
      out AssignPermissions_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      AssignPermissions assignPermissions,
      AssignPermissions_Parameters parameters,
      AssignPermissions_Request request,
      out AssignPermissions_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      AssignPermissions assignPermissions,
      AssignPermissions_Parameters parameters,
      AssignPermissions_Request request,
      out AssignPermissions_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      AssignPermissions assignPermissions,
      AssignPermissions_Parameters parameters,
      AssignPermissions_Request request,
      out AssignPermissions_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      AssignPermissions assignPermissions,
      AssignPermissions_LoadESigDetails_Parameters parameters,
      AssignPermissions_Request request,
      out AssignPermissions_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      AssignPermissions assignPermissions,
      AssignPermissions_Parameters parameters,
      AssignPermissions_Request request,
      out AssignPermissions_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      AssignPermissions assignPermissions,
      AssignPermissions_Parameters parameters,
      AssignPermissions_Request request,
      out AssignPermissions_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      AssignPermissionsMethod[] methods,
      AssignPermissions_Request request,
      out AssignPermissions_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      AssignPermissions assignPermissions,
      AssignPermissions_Request request,
      out AssignPermissions_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      AssignPermissions assignPermissions,
      AssignPermissions_Request request,
      out AssignPermissions_Result result);
  }
}
