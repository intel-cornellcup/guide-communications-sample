// **********************************************************************
//
// Copyright (c) 2003-2013 ZeroC, Inc. All rights reserved.
//
// This copy of Ice is licensed to you under the terms described in the
// ICE_LICENSE file included in this distribution.
//
// **********************************************************************
//
// Ice version 3.5.1
//
// <auto-generated>
//
// Generated from file `Example.ice'
//
// Warning: do not edit this file.
//
// </auto-generated>
//


using _System = global::System;
using _Microsoft = global::Microsoft;

#pragma warning disable 1591

namespace IceCompactId
{
}

namespace Example
{
    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1707")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1711")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1715")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1720")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1722")]
    [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1724")]
    public partial interface Converter : Ice.Object, ConverterOperations_, ConverterOperationsNC_
    {
    }
}

namespace Example
{
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public delegate void Callback_Converter_toUpper(string ret__);
}

namespace Example
{
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public interface ConverterPrx : Ice.ObjectPrx
    {
        string toUpper(string s);
        string toUpper(string s, _System.Collections.Generic.Dictionary<string, string> context__);

        Ice.AsyncResult<Example.Callback_Converter_toUpper> begin_toUpper(string s);
        Ice.AsyncResult<Example.Callback_Converter_toUpper> begin_toUpper(string s, _System.Collections.Generic.Dictionary<string, string> ctx__);

        Ice.AsyncResult begin_toUpper(string s, Ice.AsyncCallback cb__, object cookie__);
        Ice.AsyncResult begin_toUpper(string s, _System.Collections.Generic.Dictionary<string, string> ctx__, Ice.AsyncCallback cb__, object cookie__);

        string end_toUpper(Ice.AsyncResult r__);
    }
}

namespace Example
{
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public interface ConverterOperations_
    {
        string toUpper(string s, Ice.Current current__);
    }

    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public interface ConverterOperationsNC_
    {
        string toUpper(string s);
    }
}

namespace Example
{
    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public sealed class ConverterPrxHelper : Ice.ObjectPrxHelperBase, ConverterPrx
    {
        #region Synchronous operations

        public string toUpper(string s)
        {
            return toUpper(s, null, false);
        }

        public string toUpper(string s, _System.Collections.Generic.Dictionary<string, string> context__)
        {
            return toUpper(s, context__, true);
        }

        private string toUpper(string s, _System.Collections.Generic.Dictionary<string, string> context__, bool explicitContext__)
        {
            if(explicitContext__ && context__ == null)
            {
                context__ = emptyContext_;
            }
            Ice.Instrumentation.InvocationObserver observer__ = IceInternal.ObserverHelper.get(this, __toUpper_name, context__);
            int cnt__ = 0;
            try
            {
                while(true)
                {
                    Ice.ObjectDel_ delBase__ = null;
                    try
                    {
                        checkTwowayOnly__(__toUpper_name);
                        delBase__ = getDelegate__(false);
                        ConverterDel_ del__ = (ConverterDel_)delBase__;
                        return del__.toUpper(s, context__, observer__);
                    }
                    catch(IceInternal.LocalExceptionWrapper ex__)
                    {
                        handleExceptionWrapper__(delBase__, ex__, observer__);
                    }
                    catch(Ice.LocalException ex__)
                    {
                        handleException__(delBase__, ex__, true, ref cnt__, observer__);
                    }
                }
            }
            finally
            {
                if(observer__ != null)
                {
                    observer__.detach();
                }
            }
        }

        #endregion

        #region Asynchronous operations

        public Ice.AsyncResult<Example.Callback_Converter_toUpper> begin_toUpper(string s)
        {
            return begin_toUpper(s, null, false, null, null);
        }

        public Ice.AsyncResult<Example.Callback_Converter_toUpper> begin_toUpper(string s, _System.Collections.Generic.Dictionary<string, string> ctx__)
        {
            return begin_toUpper(s, ctx__, true, null, null);
        }

        public Ice.AsyncResult begin_toUpper(string s, Ice.AsyncCallback cb__, object cookie__)
        {
            return begin_toUpper(s, null, false, cb__, cookie__);
        }

        public Ice.AsyncResult begin_toUpper(string s, _System.Collections.Generic.Dictionary<string, string> ctx__, Ice.AsyncCallback cb__, object cookie__)
        {
            return begin_toUpper(s, ctx__, true, cb__, cookie__);
        }

        private const string __toUpper_name = "toUpper";

        public string end_toUpper(Ice.AsyncResult r__)
        {
            IceInternal.OutgoingAsync outAsync__ = (IceInternal.OutgoingAsync)r__;
            IceInternal.OutgoingAsync.check__(outAsync__, this, __toUpper_name);
            bool ok__ = outAsync__.wait__();
            try
            {
                if(!ok__)
                {
                    try
                    {
                        outAsync__.throwUserException__();
                    }
                    catch(Ice.UserException ex__)
                    {
                        throw new Ice.UnknownUserException(ex__.ice_name(), ex__);
                    }
                }
                string ret__;
                IceInternal.BasicStream is__ = outAsync__.startReadParams__();
                ret__ = is__.readString();
                outAsync__.endReadParams__();
                return ret__;
            }
            catch(Ice.LocalException ex)
            {
                Ice.Instrumentation.InvocationObserver obsv__ = outAsync__.getObserver__();
                if(obsv__ != null)
                {
                    obsv__.failed(ex.ice_name());
                }
                throw ex;
            }
        }

        private Ice.AsyncResult<Example.Callback_Converter_toUpper> begin_toUpper(string s, _System.Collections.Generic.Dictionary<string, string> ctx__, bool explicitContext__, Ice.AsyncCallback cb__, object cookie__)
        {
            checkAsyncTwowayOnly__(__toUpper_name);
            IceInternal.TwowayOutgoingAsync<Example.Callback_Converter_toUpper> result__ =  new IceInternal.TwowayOutgoingAsync<Example.Callback_Converter_toUpper>(this, __toUpper_name, toUpper_completed__, cookie__);
            if(cb__ != null)
            {
                result__.whenCompletedWithAsyncCallback(cb__);
            }
            try
            {
                result__.prepare__(__toUpper_name, Ice.OperationMode.Normal, ctx__, explicitContext__);
                IceInternal.BasicStream os__ = result__.startWriteParams__(Ice.FormatType.DefaultFormat);
                os__.writeString(s);
                result__.endWriteParams__();
                result__.send__(true);
            }
            catch(Ice.LocalException ex__)
            {
                result__.exceptionAsync__(ex__);
            }
            return result__;
        }

        private void toUpper_completed__(Ice.AsyncResult r__, Example.Callback_Converter_toUpper cb__, Ice.ExceptionCallback excb__)
        {
            string ret__;
            try
            {
                ret__ = end_toUpper(r__);
            }
            catch(Ice.Exception ex__)
            {
                if(excb__ != null)
                {
                    excb__(ex__);
                }
                return;
            }
            if(cb__ != null)
            {
                cb__(ret__);
            }
        }

        #endregion

        #region Checked and unchecked cast operations

        public static ConverterPrx checkedCast(Ice.ObjectPrx b)
        {
            if(b == null)
            {
                return null;
            }
            ConverterPrx r = b as ConverterPrx;
            if((r == null) && b.ice_isA(ice_staticId()))
            {
                ConverterPrxHelper h = new ConverterPrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static ConverterPrx checkedCast(Ice.ObjectPrx b, _System.Collections.Generic.Dictionary<string, string> ctx)
        {
            if(b == null)
            {
                return null;
            }
            ConverterPrx r = b as ConverterPrx;
            if((r == null) && b.ice_isA(ice_staticId(), ctx))
            {
                ConverterPrxHelper h = new ConverterPrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static ConverterPrx checkedCast(Ice.ObjectPrx b, string f)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            try
            {
                if(bb.ice_isA(ice_staticId()))
                {
                    ConverterPrxHelper h = new ConverterPrxHelper();
                    h.copyFrom__(bb);
                    return h;
                }
            }
            catch(Ice.FacetNotExistException)
            {
            }
            return null;
        }

        public static ConverterPrx checkedCast(Ice.ObjectPrx b, string f, _System.Collections.Generic.Dictionary<string, string> ctx)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            try
            {
                if(bb.ice_isA(ice_staticId(), ctx))
                {
                    ConverterPrxHelper h = new ConverterPrxHelper();
                    h.copyFrom__(bb);
                    return h;
                }
            }
            catch(Ice.FacetNotExistException)
            {
            }
            return null;
        }

        public static ConverterPrx uncheckedCast(Ice.ObjectPrx b)
        {
            if(b == null)
            {
                return null;
            }
            ConverterPrx r = b as ConverterPrx;
            if(r == null)
            {
                ConverterPrxHelper h = new ConverterPrxHelper();
                h.copyFrom__(b);
                r = h;
            }
            return r;
        }

        public static ConverterPrx uncheckedCast(Ice.ObjectPrx b, string f)
        {
            if(b == null)
            {
                return null;
            }
            Ice.ObjectPrx bb = b.ice_facet(f);
            ConverterPrxHelper h = new ConverterPrxHelper();
            h.copyFrom__(bb);
            return h;
        }

        public static readonly string[] ids__ =
        {
            "::Example::Converter",
            "::Ice::Object"
        };

        public static string ice_staticId()
        {
            return ids__[0];
        }

        #endregion

        #region Marshaling support

        protected override Ice.ObjectDelM_ createDelegateM__()
        {
            return new ConverterDelM_();
        }

        protected override Ice.ObjectDelD_ createDelegateD__()
        {
            return new ConverterDelD_();
        }

        public static void write__(IceInternal.BasicStream os__, ConverterPrx v__)
        {
            os__.writeProxy(v__);
        }

        public static ConverterPrx read__(IceInternal.BasicStream is__)
        {
            Ice.ObjectPrx proxy = is__.readProxy();
            if(proxy != null)
            {
                ConverterPrxHelper result = new ConverterPrxHelper();
                result.copyFrom__(proxy);
                return result;
            }
            return null;
        }

        #endregion
    }
}

namespace Example
{
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public interface ConverterDel_ : Ice.ObjectDel_
    {
        string toUpper(string s, _System.Collections.Generic.Dictionary<string, string> context__, Ice.Instrumentation.InvocationObserver observer__);
    }
}

namespace Example
{
    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public sealed class ConverterDelM_ : Ice.ObjectDelM_, ConverterDel_
    {
        public string toUpper(string s, _System.Collections.Generic.Dictionary<string, string> context__, Ice.Instrumentation.InvocationObserver observer__)
        {
            IceInternal.Outgoing og__ = handler__.getOutgoing("toUpper", Ice.OperationMode.Normal, context__, observer__);
            try
            {
                try
                {
                    IceInternal.BasicStream os__ = og__.startWriteParams(Ice.FormatType.DefaultFormat);
                    os__.writeString(s);
                    og__.endWriteParams();
                }
                catch(Ice.LocalException ex__)
                {
                    og__.abort(ex__);
                }
                bool ok__ = og__.invoke();
                try
                {
                    if(!ok__)
                    {
                        try
                        {
                            og__.throwUserException();
                        }
                        catch(Ice.UserException ex__)
                        {
                            throw new Ice.UnknownUserException(ex__.ice_name(), ex__);
                        }
                    }
                    IceInternal.BasicStream is__ = og__.startReadParams();
                    string ret__;
                    ret__ = is__.readString();
                    og__.endReadParams();
                    return ret__;
                }
                catch(Ice.LocalException ex__)
                {
                    throw new IceInternal.LocalExceptionWrapper(ex__, false);
                }
            }
            finally
            {
                handler__.reclaimOutgoing(og__);
            }
        }
    }
}

namespace Example
{
    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public sealed class ConverterDelD_ : Ice.ObjectDelD_, ConverterDel_
    {
        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031")]
        public string toUpper(string s, _System.Collections.Generic.Dictionary<string, string> context__, Ice.Instrumentation.InvocationObserver observer__)
        {
            Ice.Current current__ = new Ice.Current();
            initCurrent__(ref current__, "toUpper", Ice.OperationMode.Normal, context__);
            string result__ = null;
            IceInternal.Direct.RunDelegate run__ = delegate(Ice.Object obj__)
            {
                Converter servant__ = null;
                try
                {
                    servant__ = (Converter)obj__;
                }
                catch(_System.InvalidCastException)
                {
                    throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
                }
                result__ = servant__.toUpper(s, current__);
                return Ice.DispatchStatus.DispatchOK;
            };
            IceInternal.Direct direct__ = null;
            try
            {
                direct__ = new IceInternal.Direct(current__, run__);
                try
                {
                    Ice.DispatchStatus status__ = direct__.getServant().collocDispatch__(direct__);
                    _System.Diagnostics.Debug.Assert(status__ == Ice.DispatchStatus.DispatchOK);
                }
                finally
                {
                    direct__.destroy();
                }
            }
            catch(Ice.SystemException)
            {
                throw;
            }
            catch(_System.Exception ex__)
            {
                IceInternal.LocalExceptionWrapper.throwWrapper(ex__);
            }
            return result__;
        }
    }
}

namespace Example
{
    [_System.Runtime.InteropServices.ComVisible(false)]
    [_System.CodeDom.Compiler.GeneratedCodeAttribute("slice2cs", "3.5.1")]
    public abstract class ConverterDisp_ : Ice.ObjectImpl, Converter
    {
        #region Slice operations

        public string toUpper(string s)
        {
            return toUpper(s, Ice.ObjectImpl.defaultCurrent);
        }

        public abstract string toUpper(string s, Ice.Current current__);

        #endregion

        #region Slice type-related members

        public static new readonly string[] ids__ = 
        {
            "::Example::Converter",
            "::Ice::Object"
        };

        public override bool ice_isA(string s)
        {
            return _System.Array.BinarySearch(ids__, s, IceUtilInternal.StringUtil.OrdinalStringComparer) >= 0;
        }

        public override bool ice_isA(string s, Ice.Current current__)
        {
            return _System.Array.BinarySearch(ids__, s, IceUtilInternal.StringUtil.OrdinalStringComparer) >= 0;
        }

        public override string[] ice_ids()
        {
            return ids__;
        }

        public override string[] ice_ids(Ice.Current current__)
        {
            return ids__;
        }

        public override string ice_id()
        {
            return ids__[0];
        }

        public override string ice_id(Ice.Current current__)
        {
            return ids__[0];
        }

        public static new string ice_staticId()
        {
            return ids__[0];
        }

        #endregion

        #region Operation dispatch

        [_System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
        public static Ice.DispatchStatus toUpper___(Converter obj__, IceInternal.Incoming inS__, Ice.Current current__)
        {
            checkMode__(Ice.OperationMode.Normal, current__.mode);
            IceInternal.BasicStream is__ = inS__.startReadParams();
            string s;
            s = is__.readString();
            inS__.endReadParams();
            string ret__ = obj__.toUpper(s, current__);
            IceInternal.BasicStream os__ = inS__.startWriteParams__(Ice.FormatType.DefaultFormat);
            os__.writeString(ret__);
            inS__.endWriteParams__(true);
            return Ice.DispatchStatus.DispatchOK;
        }

        private static string[] all__ =
        {
            "ice_id",
            "ice_ids",
            "ice_isA",
            "ice_ping",
            "toUpper"
        };

        public override Ice.DispatchStatus dispatch__(IceInternal.Incoming inS__, Ice.Current current__)
        {
            int pos = _System.Array.BinarySearch(all__, current__.operation, IceUtilInternal.StringUtil.OrdinalStringComparer);
            if(pos < 0)
            {
                throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
            }

            switch(pos)
            {
                case 0:
                {
                    return ice_id___(this, inS__, current__);
                }
                case 1:
                {
                    return ice_ids___(this, inS__, current__);
                }
                case 2:
                {
                    return ice_isA___(this, inS__, current__);
                }
                case 3:
                {
                    return ice_ping___(this, inS__, current__);
                }
                case 4:
                {
                    return toUpper___(this, inS__, current__);
                }
            }

            _System.Diagnostics.Debug.Assert(false);
            throw new Ice.OperationNotExistException(current__.id, current__.facet, current__.operation);
        }

        #endregion

        #region Marshaling support

        protected override void writeImpl__(IceInternal.BasicStream os__)
        {
            os__.startWriteSlice(ice_staticId(), -1, true);
            os__.endWriteSlice();
        }

        protected override void readImpl__(IceInternal.BasicStream is__)
        {
            is__.startReadSlice();
            is__.endReadSlice();
        }

        #endregion
    }
}
