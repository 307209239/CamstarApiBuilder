// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICollectLotSamplingDataService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICollectLotSamplingDataService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Parameters parameters,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Parameters parameters,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Parameters parameters,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Parameters parameters,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Parameters parameters,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_LoadESigDetails_Parameters parameters,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Parameters parameters,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Parameters parameters,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CollectLotSamplingDataMethod[] methods,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CollectLotSamplingData collectLotSamplingData,
      CollectLotSamplingData_Request request,
      out CollectLotSamplingData_Result result);
  }
}
