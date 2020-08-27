// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRouteApprovalService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRouteApprovalService
  {
    [OperationContract]
    ResultStatus CreateApprover(
      UserProfile userProfile,
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result);

    [OperationContract]
    ResultStatus CreateSheet(
      UserProfile userProfile,
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheet(
      UserProfile userProfile,
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetDetails(
      UserProfile userProfile,
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result);

    [OperationContract]
    ResultStatus GetApprovalSheetTemplate(
      UserProfile userProfile,
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RouteApproval routeApproval,
      RouteApproval_LoadESigDetails_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      RouteApproval routeApproval,
      RouteApproval_Parameters parameters,
      RouteApproval_Request request,
      out RouteApproval_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RouteApprovalMethod[] methods,
      RouteApproval_Request request,
      out RouteApproval_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RouteApproval routeApproval,
      RouteApproval_Request request,
      out RouteApproval_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RouteApproval routeApproval,
      RouteApproval_Request request,
      out RouteApproval_Result result);
  }
}
