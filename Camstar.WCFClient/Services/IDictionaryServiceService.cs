// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDictionaryServiceService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDictionaryServiceService
  {
    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DictionaryService dictionaryService,
      DictionaryService_Parameters parameters,
      DictionaryService_Request request,
      out DictionaryService_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DictionaryServiceMethod[] methods,
      DictionaryService_Request request,
      out DictionaryService_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DictionaryService dictionaryService,
      DictionaryService_Request request,
      out DictionaryService_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DictionaryService dictionaryService,
      DictionaryService_Request request,
      out DictionaryService_Result result);
  }
}
