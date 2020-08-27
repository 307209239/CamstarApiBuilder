// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDictionaryMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDictionaryMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result);

    [OperationContract]
    ResultStatus DeleteOrphanDictionaryLabel(
      UserProfile userProfile,
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_LoadESigDetails_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result);

    [OperationContract]
    ResultStatus LoadWorkingSetLabels(
      UserProfile userProfile,
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result);

    [OperationContract]
    ResultStatus RemoveOrphanDictionaryLabels(
      UserProfile userProfile,
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Parameters parameters,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DictionaryMaintMethod[] methods,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DictionaryMaint dictionaryMaint,
      DictionaryMaint_Request request,
      out DictionaryMaint_Result result);
  }
}
