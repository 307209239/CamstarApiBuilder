// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICollectResourceDataService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICollectResourceDataService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CollectResourceData collectResourceData,
      CollectResourceData_Parameters parameters,
      CollectResourceData_Request request,
      out CollectResourceData_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CollectResourceData collectResourceData,
      CollectResourceData_Parameters parameters,
      CollectResourceData_Request request,
      out CollectResourceData_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CollectResourceData collectResourceData,
      CollectResourceData_Parameters parameters,
      CollectResourceData_Request request,
      out CollectResourceData_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CollectResourceData collectResourceData,
      CollectResourceData_Parameters parameters,
      CollectResourceData_Request request,
      out CollectResourceData_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CollectResourceData collectResourceData,
      CollectResourceData_Parameters parameters,
      CollectResourceData_Request request,
      out CollectResourceData_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CollectResourceData collectResourceData,
      CollectResourceData_LoadESigDetails_Parameters parameters,
      CollectResourceData_Request request,
      out CollectResourceData_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CollectResourceData collectResourceData,
      CollectResourceData_Parameters parameters,
      CollectResourceData_Request request,
      out CollectResourceData_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CollectResourceData collectResourceData,
      CollectResourceData_Parameters parameters,
      CollectResourceData_Request request,
      out CollectResourceData_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CollectResourceDataMethod[] methods,
      CollectResourceData_Request request,
      out CollectResourceData_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CollectResourceData collectResourceData,
      CollectResourceData_Request request,
      out CollectResourceData_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CollectResourceData collectResourceData,
      CollectResourceData_Request request,
      out CollectResourceData_Result result);
  }
}
