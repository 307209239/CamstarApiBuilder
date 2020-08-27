// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ITransferReworkService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ITransferReworkService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      TransferRework transferRework,
      TransferRework_Parameters parameters,
      TransferRework_Request request,
      out TransferRework_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      TransferRework transferRework,
      TransferRework_Parameters parameters,
      TransferRework_Request request,
      out TransferRework_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      TransferRework transferRework,
      TransferRework_Parameters parameters,
      TransferRework_Request request,
      out TransferRework_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      TransferRework transferRework,
      TransferRework_Parameters parameters,
      TransferRework_Request request,
      out TransferRework_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      TransferRework transferRework,
      TransferRework_Parameters parameters,
      TransferRework_Request request,
      out TransferRework_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      TransferRework transferRework,
      TransferRework_LoadESigDetails_Parameters parameters,
      TransferRework_Request request,
      out TransferRework_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      TransferRework transferRework,
      TransferRework_Parameters parameters,
      TransferRework_Request request,
      out TransferRework_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      TransferRework transferRework,
      TransferRework_Parameters parameters,
      TransferRework_Request request,
      out TransferRework_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      TransferReworkMethod[] methods,
      TransferRework_Request request,
      out TransferRework_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      TransferRework transferRework,
      TransferRework_Request request,
      out TransferRework_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      TransferRework transferRework,
      TransferRework_Request request,
      out TransferRework_Result result);
  }
}
