// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.EMailMessageMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class EMailMessageMaintService : NamedDataObjectMaintBase
  {
    public EMailMessageMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IEMailMessageMaintService), userProfile);
    }

    public ResultStatus Delete(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      result = (EMailMessageMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailMessageMaintService) this._Channel).Delete(this._UserProfile, eMailMessageMaint, parameters, request, out result) : this.AddMethod((Method) new EMailMessageMaintMethod(eMailMessageMaint, EMailMessageMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((EMailMessageMaint) null, (EMailMessageMaint_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus Delete(EMailMessageMaint eMailMessageMaint)
    {
      return this.Delete(eMailMessageMaint, (EMailMessageMaint_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus Delete(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      return this.Delete(eMailMessageMaint, (EMailMessageMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      result = (EMailMessageMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailMessageMaintService) this._Channel).Freeze(this._UserProfile, eMailMessageMaint, parameters, request, out result) : this.AddMethod((Method) new EMailMessageMaintMethod(eMailMessageMaint, EMailMessageMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((EMailMessageMaint) null, (EMailMessageMaint_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus Freeze(EMailMessageMaint eMailMessageMaint)
    {
      return this.Freeze(eMailMessageMaint, (EMailMessageMaint_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus Freeze(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      return this.Freeze(eMailMessageMaint, (EMailMessageMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      result = (EMailMessageMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailMessageMaintService) this._Channel).GetWIPMsgs(this._UserProfile, eMailMessageMaint, parameters, request, out result) : this.AddMethod((Method) new EMailMessageMaintMethod(eMailMessageMaint, EMailMessageMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((EMailMessageMaint) null, (EMailMessageMaint_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(EMailMessageMaint eMailMessageMaint)
    {
      return this.GetWIPMsgs(eMailMessageMaint, (EMailMessageMaint_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      return this.GetWIPMsgs(eMailMessageMaint, (EMailMessageMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      result = (EMailMessageMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailMessageMaintService) this._Channel).Load(this._UserProfile, eMailMessageMaint, parameters, request, out result) : this.AddMethod((Method) new EMailMessageMaintMethod(eMailMessageMaint, EMailMessageMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((EMailMessageMaint) null, (EMailMessageMaint_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus Load(EMailMessageMaint eMailMessageMaint)
    {
      return this.Load(eMailMessageMaint, (EMailMessageMaint_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus Load(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      return this.Load(eMailMessageMaint, (EMailMessageMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_LoadESigDetails_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      result = (EMailMessageMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailMessageMaintService) this._Channel).LoadESigDetails(this._UserProfile, eMailMessageMaint, parameters, request, out result) : this.AddMethod((Method) new EMailMessageMaintMethod(eMailMessageMaint, EMailMessageMaintMethods.LoadESigDetails, (EMailMessageMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((EMailMessageMaint) null, (EMailMessageMaint_LoadESigDetails_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus LoadESigDetails(EMailMessageMaint eMailMessageMaint)
    {
      return this.LoadESigDetails(eMailMessageMaint, (EMailMessageMaint_LoadESigDetails_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      return this.LoadESigDetails(eMailMessageMaint, (EMailMessageMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      result = (EMailMessageMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailMessageMaintService) this._Channel).New(this._UserProfile, eMailMessageMaint, parameters, request, out result) : this.AddMethod((Method) new EMailMessageMaintMethod(eMailMessageMaint, EMailMessageMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((EMailMessageMaint) null, (EMailMessageMaint_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus New(EMailMessageMaint eMailMessageMaint)
    {
      return this.New(eMailMessageMaint, (EMailMessageMaint_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus New(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      return this.New(eMailMessageMaint, (EMailMessageMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      result = (EMailMessageMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailMessageMaintService) this._Channel).NewCopy(this._UserProfile, eMailMessageMaint, parameters, request, out result) : this.AddMethod((Method) new EMailMessageMaintMethod(eMailMessageMaint, EMailMessageMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((EMailMessageMaint) null, (EMailMessageMaint_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus NewCopy(EMailMessageMaint eMailMessageMaint)
    {
      return this.NewCopy(eMailMessageMaint, (EMailMessageMaint_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus NewCopy(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      return this.NewCopy(eMailMessageMaint, (EMailMessageMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      result = (EMailMessageMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailMessageMaintService) this._Channel).SaveAs(this._UserProfile, eMailMessageMaint, parameters, request, out result) : this.AddMethod((Method) new EMailMessageMaintMethod(eMailMessageMaint, EMailMessageMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((EMailMessageMaint) null, (EMailMessageMaint_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus SaveAs(EMailMessageMaint eMailMessageMaint)
    {
      return this.SaveAs(eMailMessageMaint, (EMailMessageMaint_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus SaveAs(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      return this.SaveAs(eMailMessageMaint, (EMailMessageMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Parameters parameters,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      result = (EMailMessageMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailMessageMaintService) this._Channel).UnFreeze(this._UserProfile, eMailMessageMaint, parameters, request, out result) : this.AddMethod((Method) new EMailMessageMaintMethod(eMailMessageMaint, EMailMessageMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) eMailMessageMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((EMailMessageMaint) null, (EMailMessageMaint_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus UnFreeze(EMailMessageMaint eMailMessageMaint)
    {
      return this.UnFreeze(eMailMessageMaint, (EMailMessageMaint_Parameters) null, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus UnFreeze(
      EMailMessageMaint eMailMessageMaint,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      return this.UnFreeze(eMailMessageMaint, (EMailMessageMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject eMailMessageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailMessageMaint_Result result1;
        ResultStatus resultStatus = this.Delete((EMailMessageMaint) eMailMessageMaint, (EMailMessageMaint_Parameters) parameters, (EMailMessageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject eMailMessageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailMessageMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((EMailMessageMaint) eMailMessageMaint, (EMailMessageMaint_Parameters) parameters, (EMailMessageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject eMailMessageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailMessageMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((EMailMessageMaint) eMailMessageMaint, (EMailMessageMaint_LoadESigDetails_Parameters) parameters, (EMailMessageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject eMailMessageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailMessageMaint_Result result1;
        ResultStatus resultStatus = this.New((EMailMessageMaint) eMailMessageMaint, (EMailMessageMaint_Parameters) parameters, (EMailMessageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject eMailMessageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailMessageMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((EMailMessageMaint) eMailMessageMaint, (EMailMessageMaint_Parameters) parameters, (EMailMessageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject eMailMessageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailMessageMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((EMailMessageMaint) eMailMessageMaint, (EMailMessageMaint_Parameters) parameters, (EMailMessageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject eMailMessageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailMessageMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((EMailMessageMaint) eMailMessageMaint, (EMailMessageMaint_Parameters) parameters, (EMailMessageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject eMailMessageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailMessageMaint_Result result1;
        ResultStatus resultStatus = this.Load((EMailMessageMaint) eMailMessageMaint, (EMailMessageMaint_Parameters) parameters, (EMailMessageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject eMailMessageMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailMessageMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((EMailMessageMaint) eMailMessageMaint, (EMailMessageMaint_Parameters) parameters, (EMailMessageMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      result = (EMailMessageMaint_Result) null;
      try
      {
        EMailMessageMaintMethod[] methods = new EMailMessageMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IEMailMessageMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailMessageMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((EMailMessageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EMailMessageMaint cdo,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      result = (EMailMessageMaint_Result) null;
      try
      {
        return ((IEMailMessageMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailMessageMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((EMailMessageMaint) cdo, (EMailMessageMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      return this.GetEnvironment((EMailMessageMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      EMailMessageMaint cdo,
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      result = (EMailMessageMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEMailMessageMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new EMailMessageMaintMethod(cdo, EMailMessageMaintMethods.ExecuteTransaction, (EMailMessageMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EMailMessageMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((EMailMessageMaint) cdo, (EMailMessageMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(EMailMessageMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (EMailMessageMaint_Request) null, out EMailMessageMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      EMailMessageMaint_Request request,
      out EMailMessageMaint_Result result)
    {
      return this.ExecuteTransaction((EMailMessageMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(EMailMessageMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new EMailMessageMaintMethod(cdo, EMailMessageMaintMethods.AddDataTransaction, (EMailMessageMaint_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((EMailMessageMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
