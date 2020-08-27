// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IBatchDispenseService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IBatchDispenseService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      BatchDispense batchDispense,
      BatchDispense_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      BatchDispense batchDispense,
      BatchDispense_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      BatchDispense batchDispense,
      BatchDispense_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result);

    [OperationContract]
    ResultStatus GetMaterialSelectionValues(
      UserProfile userProfile,
      BatchDispense batchDispense,
      BatchDispense_GetMaterialSelectionValues_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      BatchDispense batchDispense,
      BatchDispense_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      BatchDispense batchDispense,
      BatchDispense_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      BatchDispense batchDispense,
      BatchDispense_LoadESigDetails_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      BatchDispense batchDispense,
      BatchDispense_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      BatchDispense batchDispense,
      BatchDispense_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result);

    [OperationContract]
    ResultStatus ValidateUOM(
      UserProfile userProfile,
      BatchDispense batchDispense,
      BatchDispense_ValidateUOM_Parameters parameters,
      BatchDispense_Request request,
      out BatchDispense_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      BatchDispenseMethod[] methods,
      BatchDispense_Request request,
      out BatchDispense_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      BatchDispense batchDispense,
      BatchDispense_Request request,
      out BatchDispense_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      BatchDispense batchDispense,
      BatchDispense_Request request,
      out BatchDispense_Result result);
  }
}
