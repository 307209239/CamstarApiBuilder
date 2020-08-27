// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ICreateCAPAService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ICreateCAPAService
  {
    [OperationContract]
    ResultStatus AddHistoryCrossRefs(
      UserProfile userProfile,
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result);

    [OperationContract]
    ResultStatus GetCAPAName(
      UserProfile userProfile,
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result);

    [OperationContract]
    ResultStatus SubmitCAPA(
      UserProfile userProfile,
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result);

    [OperationContract]
    ResultStatus ValidateCAPACrossRefs(
      UserProfile userProfile,
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result);

    [OperationContract]
    ResultStatus ValidateQualityObject(
      UserProfile userProfile,
      CreateCAPA createCAPA,
      CreateCAPA_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result);

    [OperationContract]
    ResultStatus ValidateServiceDetail(
      UserProfile userProfile,
      CreateCAPA createCAPA,
      CreateCAPA_ValidateServiceDetail_Parameters parameters,
      CreateCAPA_Request request,
      out CreateCAPA_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      CreateCAPAMethod[] methods,
      CreateCAPA_Request request,
      out CreateCAPA_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      CreateCAPA createCAPA,
      CreateCAPA_Request request,
      out CreateCAPA_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      CreateCAPA createCAPA,
      CreateCAPA_Request request,
      out CreateCAPA_Result result);
  }
}
