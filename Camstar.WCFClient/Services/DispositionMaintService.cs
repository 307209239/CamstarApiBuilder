// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DispositionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DispositionMaintService : NamedDataObjectMaintBase
  {
    public DispositionMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDispositionMaintService), userProfile);
    }

    public ResultStatus Delete(
      DispositionMaint dispositionMaint,
      DispositionMaint_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      result = (DispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) dispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispositionMaintService) this._Channel).Delete(this._UserProfile, dispositionMaint, parameters, request, out result) : this.AddMethod((Method) new DispositionMaintMethod(dispositionMaint, DispositionMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) dispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((DispositionMaint) null, (DispositionMaint_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus Delete(DispositionMaint dispositionMaint)
    {
      return this.Delete(dispositionMaint, (DispositionMaint_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus Delete(
      DispositionMaint dispositionMaint,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      return this.Delete(dispositionMaint, (DispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      DispositionMaint dispositionMaint,
      DispositionMaint_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      result = (DispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) dispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispositionMaintService) this._Channel).Freeze(this._UserProfile, dispositionMaint, parameters, request, out result) : this.AddMethod((Method) new DispositionMaintMethod(dispositionMaint, DispositionMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) dispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((DispositionMaint) null, (DispositionMaint_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus Freeze(DispositionMaint dispositionMaint)
    {
      return this.Freeze(dispositionMaint, (DispositionMaint_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus Freeze(
      DispositionMaint dispositionMaint,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      return this.Freeze(dispositionMaint, (DispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DispositionMaint dispositionMaint,
      DispositionMaint_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      result = (DispositionMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) dispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispositionMaintService) this._Channel).GetWIPMsgs(this._UserProfile, dispositionMaint, parameters, request, out result) : this.AddMethod((Method) new DispositionMaintMethod(dispositionMaint, DispositionMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) dispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DispositionMaint) null, (DispositionMaint_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(DispositionMaint dispositionMaint)
    {
      return this.GetWIPMsgs(dispositionMaint, (DispositionMaint_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DispositionMaint dispositionMaint,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      return this.GetWIPMsgs(dispositionMaint, (DispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DispositionMaint dispositionMaint,
      DispositionMaint_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      result = (DispositionMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) dispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispositionMaintService) this._Channel).Load(this._UserProfile, dispositionMaint, parameters, request, out result) : this.AddMethod((Method) new DispositionMaintMethod(dispositionMaint, DispositionMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) dispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DispositionMaint) null, (DispositionMaint_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus Load(DispositionMaint dispositionMaint)
    {
      return this.Load(dispositionMaint, (DispositionMaint_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus Load(
      DispositionMaint dispositionMaint,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      return this.Load(dispositionMaint, (DispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DispositionMaint dispositionMaint,
      DispositionMaint_LoadESigDetails_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      result = (DispositionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) dispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispositionMaintService) this._Channel).LoadESigDetails(this._UserProfile, dispositionMaint, parameters, request, out result) : this.AddMethod((Method) new DispositionMaintMethod(dispositionMaint, DispositionMaintMethods.LoadESigDetails, (DispositionMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) dispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DispositionMaint) null, (DispositionMaint_LoadESigDetails_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(DispositionMaint dispositionMaint)
    {
      return this.LoadESigDetails(dispositionMaint, (DispositionMaint_LoadESigDetails_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      DispositionMaint dispositionMaint,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      return this.LoadESigDetails(dispositionMaint, (DispositionMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      DispositionMaint dispositionMaint,
      DispositionMaint_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      result = (DispositionMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) dispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispositionMaintService) this._Channel).New(this._UserProfile, dispositionMaint, parameters, request, out result) : this.AddMethod((Method) new DispositionMaintMethod(dispositionMaint, DispositionMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) dispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((DispositionMaint) null, (DispositionMaint_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus New(DispositionMaint dispositionMaint)
    {
      return this.New(dispositionMaint, (DispositionMaint_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus New(
      DispositionMaint dispositionMaint,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      return this.New(dispositionMaint, (DispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      DispositionMaint dispositionMaint,
      DispositionMaint_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      result = (DispositionMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) dispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispositionMaintService) this._Channel).NewCopy(this._UserProfile, dispositionMaint, parameters, request, out result) : this.AddMethod((Method) new DispositionMaintMethod(dispositionMaint, DispositionMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) dispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((DispositionMaint) null, (DispositionMaint_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus NewCopy(DispositionMaint dispositionMaint)
    {
      return this.NewCopy(dispositionMaint, (DispositionMaint_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus NewCopy(
      DispositionMaint dispositionMaint,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      return this.NewCopy(dispositionMaint, (DispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      DispositionMaint dispositionMaint,
      DispositionMaint_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      result = (DispositionMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) dispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispositionMaintService) this._Channel).SaveAs(this._UserProfile, dispositionMaint, parameters, request, out result) : this.AddMethod((Method) new DispositionMaintMethod(dispositionMaint, DispositionMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) dispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((DispositionMaint) null, (DispositionMaint_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus SaveAs(DispositionMaint dispositionMaint)
    {
      return this.SaveAs(dispositionMaint, (DispositionMaint_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus SaveAs(
      DispositionMaint dispositionMaint,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      return this.SaveAs(dispositionMaint, (DispositionMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      DispositionMaint dispositionMaint,
      DispositionMaint_Parameters parameters,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      result = (DispositionMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) dispositionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispositionMaintService) this._Channel).UnFreeze(this._UserProfile, dispositionMaint, parameters, request, out result) : this.AddMethod((Method) new DispositionMaintMethod(dispositionMaint, DispositionMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) dispositionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((DispositionMaint) null, (DispositionMaint_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus UnFreeze(DispositionMaint dispositionMaint)
    {
      return this.UnFreeze(dispositionMaint, (DispositionMaint_Parameters) null, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus UnFreeze(
      DispositionMaint dispositionMaint,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      return this.UnFreeze(dispositionMaint, (DispositionMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject dispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispositionMaint_Result result1;
        ResultStatus resultStatus = this.Delete((DispositionMaint) dispositionMaint, (DispositionMaint_Parameters) parameters, (DispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject dispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispositionMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((DispositionMaint) dispositionMaint, (DispositionMaint_Parameters) parameters, (DispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject dispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispositionMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DispositionMaint) dispositionMaint, (DispositionMaint_LoadESigDetails_Parameters) parameters, (DispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject dispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispositionMaint_Result result1;
        ResultStatus resultStatus = this.New((DispositionMaint) dispositionMaint, (DispositionMaint_Parameters) parameters, (DispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject dispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispositionMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((DispositionMaint) dispositionMaint, (DispositionMaint_Parameters) parameters, (DispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject dispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispositionMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((DispositionMaint) dispositionMaint, (DispositionMaint_Parameters) parameters, (DispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject dispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispositionMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((DispositionMaint) dispositionMaint, (DispositionMaint_Parameters) parameters, (DispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject dispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispositionMaint_Result result1;
        ResultStatus resultStatus = this.Load((DispositionMaint) dispositionMaint, (DispositionMaint_Parameters) parameters, (DispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject dispositionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DispositionMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DispositionMaint) dispositionMaint, (DispositionMaint_Parameters) parameters, (DispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      result = (DispositionMaint_Result) null;
      try
      {
        DispositionMaintMethod[] methods = new DispositionMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDispositionMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DispositionMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DispositionMaint cdo,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      result = (DispositionMaint_Result) null;
      try
      {
        return ((IDispositionMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DispositionMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((DispositionMaint) cdo, (DispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      return this.GetEnvironment((DispositionMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DispositionMaint cdo,
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      result = (DispositionMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDispositionMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DispositionMaintMethod(cdo, DispositionMaintMethods.ExecuteTransaction, (DispositionMaint_Parameters) null));
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
        DispositionMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DispositionMaint) cdo, (DispositionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DispositionMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (DispositionMaint_Request) null, out DispositionMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DispositionMaint_Request request,
      out DispositionMaint_Result result)
    {
      return this.ExecuteTransaction((DispositionMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DispositionMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DispositionMaintMethod(cdo, DispositionMaintMethods.AddDataTransaction, (DispositionMaint_Parameters) null));
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
        return this.AddDataTransaction((DispositionMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
