// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.FactoryMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class FactoryMaintService : NamedDataObjectMaintBase
  {
    public FactoryMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IFactoryMaintService), userProfile);
    }

    public ResultStatus Delete(
      FactoryMaint factoryMaint,
      FactoryMaint_Parameters parameters,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      result = (FactoryMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) factoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFactoryMaintService) this._Channel).Delete(this._UserProfile, factoryMaint, parameters, request, out result) : this.AddMethod((Method) new FactoryMaintMethod(factoryMaint, FactoryMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) factoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((FactoryMaint) null, (FactoryMaint_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus Delete(FactoryMaint factoryMaint)
    {
      return this.Delete(factoryMaint, (FactoryMaint_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus Delete(
      FactoryMaint factoryMaint,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      return this.Delete(factoryMaint, (FactoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      FactoryMaint factoryMaint,
      FactoryMaint_Parameters parameters,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      result = (FactoryMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) factoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFactoryMaintService) this._Channel).Freeze(this._UserProfile, factoryMaint, parameters, request, out result) : this.AddMethod((Method) new FactoryMaintMethod(factoryMaint, FactoryMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) factoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((FactoryMaint) null, (FactoryMaint_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus Freeze(FactoryMaint factoryMaint)
    {
      return this.Freeze(factoryMaint, (FactoryMaint_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus Freeze(
      FactoryMaint factoryMaint,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      return this.Freeze(factoryMaint, (FactoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      FactoryMaint factoryMaint,
      FactoryMaint_Parameters parameters,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      result = (FactoryMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) factoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFactoryMaintService) this._Channel).GetWIPMsgs(this._UserProfile, factoryMaint, parameters, request, out result) : this.AddMethod((Method) new FactoryMaintMethod(factoryMaint, FactoryMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) factoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((FactoryMaint) null, (FactoryMaint_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(FactoryMaint factoryMaint)
    {
      return this.GetWIPMsgs(factoryMaint, (FactoryMaint_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      FactoryMaint factoryMaint,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      return this.GetWIPMsgs(factoryMaint, (FactoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      FactoryMaint factoryMaint,
      FactoryMaint_Parameters parameters,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      result = (FactoryMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) factoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFactoryMaintService) this._Channel).Load(this._UserProfile, factoryMaint, parameters, request, out result) : this.AddMethod((Method) new FactoryMaintMethod(factoryMaint, FactoryMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) factoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((FactoryMaint) null, (FactoryMaint_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus Load(FactoryMaint factoryMaint)
    {
      return this.Load(factoryMaint, (FactoryMaint_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus Load(
      FactoryMaint factoryMaint,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      return this.Load(factoryMaint, (FactoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      FactoryMaint factoryMaint,
      FactoryMaint_LoadESigDetails_Parameters parameters,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      result = (FactoryMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) factoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFactoryMaintService) this._Channel).LoadESigDetails(this._UserProfile, factoryMaint, parameters, request, out result) : this.AddMethod((Method) new FactoryMaintMethod(factoryMaint, FactoryMaintMethods.LoadESigDetails, (FactoryMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) factoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((FactoryMaint) null, (FactoryMaint_LoadESigDetails_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus LoadESigDetails(FactoryMaint factoryMaint)
    {
      return this.LoadESigDetails(factoryMaint, (FactoryMaint_LoadESigDetails_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      FactoryMaint factoryMaint,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      return this.LoadESigDetails(factoryMaint, (FactoryMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      FactoryMaint factoryMaint,
      FactoryMaint_Parameters parameters,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      result = (FactoryMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) factoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFactoryMaintService) this._Channel).New(this._UserProfile, factoryMaint, parameters, request, out result) : this.AddMethod((Method) new FactoryMaintMethod(factoryMaint, FactoryMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) factoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((FactoryMaint) null, (FactoryMaint_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus New(FactoryMaint factoryMaint)
    {
      return this.New(factoryMaint, (FactoryMaint_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus New(
      FactoryMaint factoryMaint,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      return this.New(factoryMaint, (FactoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      FactoryMaint factoryMaint,
      FactoryMaint_Parameters parameters,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      result = (FactoryMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) factoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFactoryMaintService) this._Channel).NewCopy(this._UserProfile, factoryMaint, parameters, request, out result) : this.AddMethod((Method) new FactoryMaintMethod(factoryMaint, FactoryMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) factoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((FactoryMaint) null, (FactoryMaint_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus NewCopy(FactoryMaint factoryMaint)
    {
      return this.NewCopy(factoryMaint, (FactoryMaint_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus NewCopy(
      FactoryMaint factoryMaint,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      return this.NewCopy(factoryMaint, (FactoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      FactoryMaint factoryMaint,
      FactoryMaint_Parameters parameters,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      result = (FactoryMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) factoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFactoryMaintService) this._Channel).SaveAs(this._UserProfile, factoryMaint, parameters, request, out result) : this.AddMethod((Method) new FactoryMaintMethod(factoryMaint, FactoryMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) factoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((FactoryMaint) null, (FactoryMaint_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus SaveAs(FactoryMaint factoryMaint)
    {
      return this.SaveAs(factoryMaint, (FactoryMaint_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus SaveAs(
      FactoryMaint factoryMaint,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      return this.SaveAs(factoryMaint, (FactoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      FactoryMaint factoryMaint,
      FactoryMaint_Parameters parameters,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      result = (FactoryMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) factoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFactoryMaintService) this._Channel).UnFreeze(this._UserProfile, factoryMaint, parameters, request, out result) : this.AddMethod((Method) new FactoryMaintMethod(factoryMaint, FactoryMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) factoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((FactoryMaint) null, (FactoryMaint_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus UnFreeze(FactoryMaint factoryMaint)
    {
      return this.UnFreeze(factoryMaint, (FactoryMaint_Parameters) null, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus UnFreeze(
      FactoryMaint factoryMaint,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      return this.UnFreeze(factoryMaint, (FactoryMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject factoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FactoryMaint_Result result1;
        ResultStatus resultStatus = this.Delete((FactoryMaint) factoryMaint, (FactoryMaint_Parameters) parameters, (FactoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject factoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FactoryMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((FactoryMaint) factoryMaint, (FactoryMaint_Parameters) parameters, (FactoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject factoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FactoryMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((FactoryMaint) factoryMaint, (FactoryMaint_LoadESigDetails_Parameters) parameters, (FactoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject factoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FactoryMaint_Result result1;
        ResultStatus resultStatus = this.New((FactoryMaint) factoryMaint, (FactoryMaint_Parameters) parameters, (FactoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject factoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FactoryMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((FactoryMaint) factoryMaint, (FactoryMaint_Parameters) parameters, (FactoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject factoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FactoryMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((FactoryMaint) factoryMaint, (FactoryMaint_Parameters) parameters, (FactoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject factoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FactoryMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((FactoryMaint) factoryMaint, (FactoryMaint_Parameters) parameters, (FactoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject factoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FactoryMaint_Result result1;
        ResultStatus resultStatus = this.Load((FactoryMaint) factoryMaint, (FactoryMaint_Parameters) parameters, (FactoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject factoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        FactoryMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((FactoryMaint) factoryMaint, (FactoryMaint_Parameters) parameters, (FactoryMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      result = (FactoryMaint_Result) null;
      try
      {
        FactoryMaintMethod[] methods = new FactoryMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IFactoryMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        FactoryMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((FactoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FactoryMaint cdo,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      result = (FactoryMaint_Result) null;
      try
      {
        return ((IFactoryMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        FactoryMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((FactoryMaint) cdo, (FactoryMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      return this.GetEnvironment((FactoryMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      FactoryMaint cdo,
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      result = (FactoryMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IFactoryMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new FactoryMaintMethod(cdo, FactoryMaintMethods.ExecuteTransaction, (FactoryMaint_Parameters) null));
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
        FactoryMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((FactoryMaint) cdo, (FactoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(FactoryMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (FactoryMaint_Request) null, out FactoryMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      FactoryMaint_Request request,
      out FactoryMaint_Result result)
    {
      return this.ExecuteTransaction((FactoryMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(FactoryMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new FactoryMaintMethod(cdo, FactoryMaintMethods.AddDataTransaction, (FactoryMaint_Parameters) null));
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
        return this.AddDataTransaction((FactoryMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
