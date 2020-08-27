// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IReorderProcessObjectService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IReorderProcessObjectService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Parameters parameters,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Parameters parameters,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Parameters parameters,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Parameters parameters,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Parameters parameters,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Parameters parameters,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Parameters parameters,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Parameters parameters,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ReorderProcessObjectMethod[] methods,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ReorderProcessObject reorderProcessObject,
      ReorderProcessObject_Request request,
      out ReorderProcessObject_Result result);
  }
}
