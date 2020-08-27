// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IPrintLabelsTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IPrintLabelsTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_LoadESigDetails_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result);

    [OperationContract]
    ResultStatus PopulateService(
      UserProfile userProfile,
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_PopulateService_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result);

    [OperationContract]
    ResultStatus PopulateService_User(
      UserProfile userProfile,
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      PrintLabelsTxnMethod[] methods,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result);
  }
}
