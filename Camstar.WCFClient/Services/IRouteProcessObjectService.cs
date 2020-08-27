// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IRouteProcessObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IRouteProcessObjectService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Parameters parameters,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Parameters parameters,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Parameters parameters,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Parameters parameters,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Parameters parameters,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Parameters parameters,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Parameters parameters,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Parameters parameters,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      RouteProcessObjectMethod[] methods,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      RouteProcessObject routeProcessObject,
      RouteProcessObject_Request request,
      out RouteProcessObject_Result result);
  }
}
